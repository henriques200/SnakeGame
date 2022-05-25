namespace SnakeGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_easy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.btn_very_hard = new System.Windows.Forms.Button();
            this.leaders_board = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Jogo da Cobra";
            // 
            // btn_easy
            // 
            this.btn_easy.Location = new System.Drawing.Point(146, 57);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(91, 23);
            this.btn_easy.TabIndex = 1;
            this.btn_easy.Text = "Normal";
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.button1_Click);
            this.btn_easy.MouseHover += new System.EventHandler(this.btn_easy_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sobre o Jogo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Location = new System.Drawing.Point(243, 57);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(91, 23);
            this.btn_hard.TabIndex = 4;
            this.btn_hard.Text = "Dificil";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            this.btn_hard.MouseHover += new System.EventHandler(this.btn_hard_MouseHover);
            // 
            // btn_very_hard
            // 
            this.btn_very_hard.Location = new System.Drawing.Point(340, 57);
            this.btn_very_hard.Name = "btn_very_hard";
            this.btn_very_hard.Size = new System.Drawing.Size(91, 23);
            this.btn_very_hard.TabIndex = 5;
            this.btn_very_hard.Text = "Muito Dificil";
            this.btn_very_hard.UseVisualStyleBackColor = true;
            this.btn_very_hard.Click += new System.EventHandler(this.btn_very_hard_Click);
            this.btn_very_hard.MouseHover += new System.EventHandler(this.btn_very_hard_MouseHover);
            // 
            // leaders_board
            // 
            this.leaders_board.AutoSize = true;
            this.leaders_board.Location = new System.Drawing.Point(12, 193);
            this.leaders_board.Name = "leaders_board";
            this.leaders_board.Size = new System.Drawing.Size(35, 13);
            this.leaders_board.TabIndex = 6;
            this.leaders_board.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pontuações mais altas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Clica na Janela para Atualizar)";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leaders_board);
            this.Controls.Add(this.btn_very_hard);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Jogo da Cobra - Menu Principal";
            this.Click += new System.EventHandler(this.MainMenu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Button btn_very_hard;
        private System.Windows.Forms.Label leaders_board;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}