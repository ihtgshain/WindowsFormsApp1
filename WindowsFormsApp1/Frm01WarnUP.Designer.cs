
namespace WindowsFormsApp1
{
    partial class Frm01WarnUP
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm01WarnUP));
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnDelecated = new System.Windows.Forms.Button();
            this.btnDelecate = new System.Windows.Forms.Button();
            this.btnNF = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnHelloForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(166, 266);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(111, 36);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            // 
            // btnHi
            // 
            this.btnHi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(324, 266);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(111, 36);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(189, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(293, 190);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 29);
            this.txtName.TabIndex = 3;
            // 
            // btnProperty
            // 
            this.btnProperty.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProperty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProperty.Location = new System.Drawing.Point(252, 334);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(111, 36);
            this.btnProperty.TabIndex = 1;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnDelecated
            // 
            this.btnDelecated.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelecated.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelecated.Location = new System.Drawing.Point(12, 12);
            this.btnDelecated.Name = "btnDelecated";
            this.btnDelecated.Size = new System.Drawing.Size(111, 36);
            this.btnDelecated.TabIndex = 4;
            this.btnDelecated.Text = "Delecated";
            this.btnDelecated.UseVisualStyleBackColor = true;
            // 
            // btnDelecate
            // 
            this.btnDelecate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelecate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelecate.Location = new System.Drawing.Point(157, 12);
            this.btnDelecate.Name = "btnDelecate";
            this.btnDelecate.Size = new System.Drawing.Size(111, 36);
            this.btnDelecate.TabIndex = 5;
            this.btnDelecate.Text = "+=";
            this.btnDelecate.UseVisualStyleBackColor = true;
            this.btnDelecate.Click += new System.EventHandler(this.btnDelecate_Click);
            // 
            // btnNF
            // 
            this.btnNF.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNF.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNF.Location = new System.Drawing.Point(335, 12);
            this.btnNF.Name = "btnNF";
            this.btnNF.Size = new System.Drawing.Size(111, 36);
            this.btnNF.TabIndex = 6;
            this.btnNF.Text = "NewForm1()";
            this.btnNF.UseVisualStyleBackColor = true;
            this.btnNF.Click += new System.EventHandler(this.btnNF_Click);
            // 
            // btnSI
            // 
            this.btnSI.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSI.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSI.Location = new System.Drawing.Point(275, 64);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(232, 36);
            this.btnSI.TabIndex = 7;
            this.btnSI.Text = "Static VS Instance Property";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.btnSI_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCopy.Location = new System.Drawing.Point(275, 106);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(232, 36);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Static VS Instance Method";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnHelloForm
            // 
            this.btnHelloForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelloForm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHelloForm.Location = new System.Drawing.Point(166, 224);
            this.btnHelloForm.Name = "btnHelloForm";
            this.btnHelloForm.Size = new System.Drawing.Size(111, 36);
            this.btnHelloForm.TabIndex = 9;
            this.btnHelloForm.Text = "Hello Form";
            this.btnHelloForm.UseVisualStyleBackColor = true;
            this.btnHelloForm.Click += new System.EventHandler(this.btnHelloForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(460, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelloForm);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.btnNF);
            this.Controls.Add(this.btnDelecate);
            this.Controls.Add(this.btnDelecated);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnDelecated;
        private System.Windows.Forms.Button btnDelecate;
        private System.Windows.Forms.Button btnNF;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnHelloForm;
        private System.Windows.Forms.Button btnClose;
    }
}

