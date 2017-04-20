namespace DigDes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_convert = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.button_selectImage = new System.Windows.Forms.Button();
            this.button_selectText = new System.Windows.Forms.Button();
            this.label_pathToResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(121, 105);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(158, 23);
            this.button_convert.TabIndex = 0;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(217, 34);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(0, 13);
            this.label_path.TabIndex = 4;
            // 
            // button_selectImage
            // 
            this.button_selectImage.Location = new System.Drawing.Point(38, 29);
            this.button_selectImage.Name = "button_selectImage";
            this.button_selectImage.Size = new System.Drawing.Size(158, 23);
            this.button_selectImage.TabIndex = 5;
            this.button_selectImage.Text = "Select image";
            this.button_selectImage.UseVisualStyleBackColor = true;
            this.button_selectImage.Click += new System.EventHandler(this.button_selectImage_Click);
            // 
            // button_selectText
            // 
            this.button_selectText.Location = new System.Drawing.Point(38, 58);
            this.button_selectText.Name = "button_selectText";
            this.button_selectText.Size = new System.Drawing.Size(158, 27);
            this.button_selectText.TabIndex = 6;
            this.button_selectText.Text = "Select path to save the result ";
            this.button_selectText.UseVisualStyleBackColor = true;
            this.button_selectText.Click += new System.EventHandler(this.button_selectText_Click);
            // 
            // label_pathToResult
            // 
            this.label_pathToResult.AutoSize = true;
            this.label_pathToResult.Location = new System.Drawing.Point(217, 65);
            this.label_pathToResult.Name = "label_pathToResult";
            this.label_pathToResult.Size = new System.Drawing.Size(0, 13);
            this.label_pathToResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 140);
            this.Controls.Add(this.label_pathToResult);
            this.Controls.Add(this.button_selectText);
            this.Controls.Add(this.button_selectImage);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_convert);
            this.Name = "Form1";
            this.Text = "Image to text converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Button button_selectImage;
        private System.Windows.Forms.Button button_selectText;
        private System.Windows.Forms.Label label_pathToResult;
    }
}

