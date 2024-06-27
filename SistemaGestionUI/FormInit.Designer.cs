namespace SistemaGestionUI;

partial class FormInit
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
        Title = new Label();
        btnUser = new Button();
        btnProduct = new Button();
        btnSellProduct = new Button();
        btnSell = new Button();
        btnExit = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // Title
        // 
        Title.AutoSize = true;
        Title.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point);
        Title.ForeColor = Color.Blue;
        Title.Location = new Point(420, 95);
        Title.Margin = new Padding(4, 0, 4, 0);
        Title.Name = "Title";
        Title.Size = new Size(282, 54);
        Title.TabIndex = 0;
        Title.Text = "Orofino sa";
        Title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnUser
        // 
        btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnUser.ForeColor = Color.Blue;
        btnUser.Location = new Point(54, 357);
        btnUser.Margin = new Padding(4, 5, 4, 5);
        btnUser.Name = "btnUser";
        btnUser.Size = new Size(209, 112);
        btnUser.TabIndex = 1;
        btnUser.Text = "Usuarios";
        btnUser.UseVisualStyleBackColor = true;
        btnUser.Click += btnUser_Click;
        // 
        // btnProduct
        // 
        btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnProduct.ForeColor = Color.Blue;
        btnProduct.Location = new Point(333, 357);
        btnProduct.Margin = new Padding(4, 5, 4, 5);
        btnProduct.Name = "btnProduct";
        btnProduct.Size = new Size(191, 112);
        btnProduct.TabIndex = 2;
        btnProduct.Text = "Productos";
        btnProduct.UseVisualStyleBackColor = true;
        btnProduct.Click += btnProduct_Click;
        // 
        // btnSellProduct
        // 
        btnSellProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSellProduct.ForeColor = Color.Blue;
        btnSellProduct.Location = new Point(587, 357);
        btnSellProduct.Margin = new Padding(4, 5, 4, 5);
        btnSellProduct.Name = "btnSellProduct";
        btnSellProduct.Size = new Size(216, 112);
        btnSellProduct.TabIndex = 3;
        btnSellProduct.Text = "Productos vendidos";
        btnSellProduct.UseVisualStyleBackColor = true;
        btnSellProduct.Click += btnSellProduct_Click;
        // 
        // btnSell
        // 
        btnSell.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btnSell.ForeColor = Color.Blue;
        btnSell.Location = new Point(871, 357);
        btnSell.Margin = new Padding(4, 5, 4, 5);
        btnSell.Name = "btnSell";
        btnSell.Size = new Size(201, 112);
        btnSell.TabIndex = 4;
        btnSell.Text = "Ventas";
        btnSell.UseVisualStyleBackColor = true;
        btnSell.Click += btnSell_Click;
        // 
        // btnExit
        // 
        btnExit.ForeColor = Color.Blue;
        btnExit.Location = new Point(526, 665);
        btnExit.Margin = new Padding(4, 5, 4, 5);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(107, 38);
        btnExit.TabIndex = 5;
        btnExit.Text = "Salir";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ButtonFace;
        label1.Location = new Point(355, 179);
        label1.Name = "label1";
        label1.Size = new Size(426, 40);
        label1.TabIndex = 6;
        label1.Text = "Introductora Slender";
        // 
        // FormInit
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.WindowText;
        ClientSize = new Size(1143, 750);
        Controls.Add(label1);
        Controls.Add(btnExit);
        Controls.Add(btnSell);
        Controls.Add(btnSellProduct);
        Controls.Add(btnProduct);
        Controls.Add(btnUser);
        Controls.Add(Title);
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormInit";
        Text = "Sistema de Gestion";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Title;
    private Button btnUser;
    private Button btnProduct;
    private Button btnSellProduct;
    private Button btnSell;
    private Button btnExit;
    private Label label1;
}