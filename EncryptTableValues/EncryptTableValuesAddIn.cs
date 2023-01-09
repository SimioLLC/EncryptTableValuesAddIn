using System;
using System.Collections.Generic;
using System.Text;
using SimioAPI;
using SimioAPI.Extensions;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using EncryptTableValuesAddIn;
using EncryptTableValuesAddIn.Properties;

namespace EnableDatatablesForPlanningViewAddIn
{
    public class EncryptTableValuesAddIn : IDesignAddIn
    {
        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "EncryptTableValues"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.  
        /// </summary>
        public string Description
        {
            get { return "Description text for the 'EncryptTableValues' add-in."; }
        }

        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public System.Drawing.Image Icon
        {
            get { return Resources.Icon; }
        }

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {
            int count = 0;
            // This example code places some new objects from the Standard Library into the active model of the project.
            if (context.ActiveModel != null)
            {
                var encryptTable = context.ActiveModel.Tables["EncryptTable"];

                if (encryptTable == null)
                {
                    encryptTable = context.ActiveModel.Tables.Create("EncryptTable");
                    encryptTable.Columns.AddStringColumn("Key", String.Empty);
                    var row = encryptTable.Rows.Create();
                    row.Properties["Key"].Value = Guid.NewGuid().ToString().Replace("-", "");
                    MessageBox.Show("EncryptTable Create....Use this table to edit key");
                }

                var f = new EncryptTableValueForm(context);
                foreach (var row in encryptTable.Rows)
                {
                    var prop = row.Properties["Key"];
                    if (prop == null) throw new Exception("Key column not found");
                    f.KeyTextbox.Text = prop.Value;
                    foreach (var table in context.ActiveModel.Tables)
                    {
                        if (table.Name != "EncryptTable") f.TableComboBox.Items.Add(table.Name);
                    }
                    f.ShowDialog();
                    break;
                }

                if (f.DialogResult == DialogResult.OK)
                {
                    context.ActiveModel.BulkUpdate(model =>
                    {
                        // Set Encrypt Table Values
                        foreach (var table in context.ActiveModel.Tables)
                        {
                            if (table.Name == f.TableComboBox.Text)
                            {
                                foreach (var row in table.Rows)
                                {
                                    foreach (var prop in row.Properties)
                                    {
                                        if (prop.Name == f.ColumnComboBox.Text)
                                        {
                                            if (f.EncryptRadioButton.Checked == true)
                                                prop.Value = EncryptString(f.KeyTextbox.Text, prop.Value);
                                            else
                                                prop.Value = DecryptString(f.KeyTextbox.Text, prop.Value);
                                            count++;
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    });

                    System.Windows.Forms.MessageBox.Show("Properties Update : " + count.ToString());
                }
            }
        }

        private string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            if (key.Length != 32) throw new Exception("Key Must Be 32 Characters Long");

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        private string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
        #endregion
    }
}
