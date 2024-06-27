namespace SistemaGestionUI.FormUsuario;

partial class FormCrud_User
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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        txtId = new TextBox();
        txtNombre = new TextBox();
        txtApellido = new TextBox();
        txtUsuario = new TextBox();
        txtPass = new TextBox();
        txtMail = new TextBox();
        lblUser = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.Blue;
        button1.Location = new Point(160, 563);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(107, 38);
        button1.TabIndex = 0;
        button1.Text = "Volver";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
        button2.ForeColor = Color.Blue;
        button2.Location = new Point(276, 563);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(107, 38);
        button2.TabIndex = 1;
        button2.Text = "Eliminar";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
        button3.ForeColor = Color.Blue;
        button3.Location = new Point(391, 563);
        button3.Margin = new Padding(4, 5, 4, 5);
        button3.Name = "button3";
        button3.Size = new Size(107, 38);
        button3.TabIndex = 2;
        button3.Text = "Guardar";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label1.Location = new Point(53, 91);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(36, 26);
        label1.TabIndex = 3;
        label1.Text = "ID";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label2.Location = new Point(47, 156);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(101, 26);
        label2.TabIndex = 4;
        label2.Text = "Nombre";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label3.Location = new Point(43, 230);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(115, 26);
        label3.TabIndex = 5;
        label3.Text = "Apellido";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label4.Location = new Point(43, 310);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(105, 26);
        label4.TabIndex = 6;
        label4.Text = "Usuario";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label5.Location = new Point(53, 459);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(63, 26);
        label5.TabIndex = 7;
        label5.Text = "Mail";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label6.Location = new Point(24, 379);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(147, 26);
        label6.TabIndex = 8;
        label6.Text = "Contrasena";
        // 
        // txtId
        // 
        txtId.Location = new Point(191, 85);
        txtId.Margin = new Padding(4, 5, 4, 5);
        txtId.Name = "txtId";
        txtId.ReadOnly = true;
        txtId.Size = new Size(305, 31);
        txtId.TabIndex = 9;
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(191, 150);
        txtNombre.Margin = new Padding(4, 5, 4, 5);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(305, 31);
        txtNombre.TabIndex = 10;
        // 
        // txtApellido
        // 
        txtApellido.Location = new Point(191, 225);
        txtApellido.Margin = new Padding(4, 5, 4, 5);
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(305, 31);
        txtApellido.TabIndex = 11;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new Point(193, 305);
        txtUsuario.Margin = new Padding(4, 5, 4, 5);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(305, 31);
        txtUsuario.TabIndex = 12;
        // 
        // txtPass
        // 
        txtPass.Location = new Point(179, 374);
        txtPass.Margin = new Padding(4, 5, 4, 5);
        txtPass.Name = "txtPass";
        txtPass.Size = new Size(305, 31);
        txtPass.TabIndex = 13;
        // 
        // txtMail
        // 
        txtMail.Location = new Point(191, 453);
        txtMail.Margin = new Padding(4, 5, 4, 5);
        txtMail.Name = "txtMail";
        txtMail.Size = new Size(305, 31);
        txtMail.TabIndex = 14;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        lblUser.ForeColor = Color.Blue;
        lblUser.Location = new Point(53, 26);
        lblUser.Margin = new Padding(4, 0, 4, 0);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(158, 35);
        lblUser.TabIndex = 15;
        lblUser.Text = "Usuarios";
        // 
        // FormCrud_User
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(647, 698);
        Controls.Add(lblUser);
        Controls.Add(txtMail);
        Controls.Add(txtPass);
        Controls.Add(txtUsuario);
        Controls.Add(txtApellido);
        Controls.Add(txtNombre);
        Controls.Add(txtId);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormCrud_User";
        Text = "Gestion de Usuarios";
        Load += FormCrud_User_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox txtId;
    private TextBox txtNombre;
    private TextBox txtApellido;
    private TextBox txtUsuario;
    private TextBox txtPass;
    private TextBox txtMail;
    private Label lblUser;
}