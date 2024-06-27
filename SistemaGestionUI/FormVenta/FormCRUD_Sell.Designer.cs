namespace SistemaGestionUI.FormVenta
{
    partial class FormCRUD_Sell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            txtSellId = new TextBox();
            lblId = new Label();
            txtUserId = new TextBox();
            txtCommentary = new TextBox();
            lblUserId = new Label();
            lblComentary = new Label();
            lblVenta = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(369, 467);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 31;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Blue;
            btnDelete.Location = new Point(253, 467);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(137, 467);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 29;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(253, 145);
            txtSellId.Margin = new Padding(4, 5, 4, 5);
            txtSellId.Name = "txtSellId";
            txtSellId.ReadOnly = true;
            txtSellId.Size = new Size(340, 31);
            txtSellId.TabIndex = 28;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(57, 150);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(108, 26);
            lblId.TabIndex = 27;
            lblId.Text = "ID Venta";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(253, 330);
            txtUserId.Margin = new Padding(4, 5, 4, 5);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(340, 31);
            txtUserId.TabIndex = 23;
            // 
            // txtCommentary
            // 
            txtCommentary.Location = new Point(253, 233);
            txtCommentary.Margin = new Padding(4, 5, 4, 5);
            txtCommentary.Name = "txtCommentary";
            txtCommentary.Size = new Size(340, 31);
            txtCommentary.TabIndex = 22;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUserId.ForeColor = Color.Black;
            lblUserId.Location = new Point(57, 331);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(156, 26);
            lblUserId.TabIndex = 18;
            lblUserId.Text = "Id Vendedor";
            lblUserId.Click += lblUserId_Click;
            // 
            // lblComentary
            // 
            lblComentary.AutoSize = true;
            lblComentary.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentary.ForeColor = SystemColors.ControlText;
            lblComentary.Location = new Point(57, 238);
            lblComentary.Margin = new Padding(4, 0, 4, 0);
            lblComentary.Name = "lblComentary";
            lblComentary.Size = new Size(162, 26);
            lblComentary.TabIndex = 17;
            lblComentary.Text = "Comentarios";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVenta.ForeColor = Color.Blue;
            lblVenta.Location = new Point(57, 30);
            lblVenta.Margin = new Padding(4, 0, 4, 0);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(123, 35);
            lblVenta.TabIndex = 16;
            lblVenta.Text = "Ventas";
            // 
            // FormCRUD_Sell
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 550);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtSellId);
            Controls.Add(lblId);
            Controls.Add(txtUserId);
            Controls.Add(txtCommentary);
            Controls.Add(lblUserId);
            Controls.Add(lblComentary);
            Controls.Add(lblVenta);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCRUD_Sell";
            Text = "Ventas";
            Load += FormCRUD_Sell_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtSellId;
        private Label lblId;
        private TextBox txtUserId;
        private TextBox txtCommentary;
        private Label lblUserId;
        private Label lblComentary;
        private Label lblVenta;
    }
}