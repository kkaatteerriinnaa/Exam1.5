namespace Exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewTaskbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LV_ToDo = new ListView();
            LV_ToDo_P = new ListView();
            LV_ToDo_C = new ListView();
            buttonDark = new Button();
            buttonPink = new Button();
            SuspendLayout();
            // 
            // NewTaskbtn
            // 
            NewTaskbtn.FlatStyle = FlatStyle.Flat;
            NewTaskbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewTaskbtn.Location = new Point(434, 12);
            NewTaskbtn.Name = "NewTaskbtn";
            NewTaskbtn.Size = new Size(216, 65);
            NewTaskbtn.TabIndex = 0;
            NewTaskbtn.Text = "Новая задача";
            NewTaskbtn.UseVisualStyleBackColor = true;
            NewTaskbtn.Click += NewTaskbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 108);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Надо Сделать";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "В процессе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(876, 108);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Готово";
            // 
            // LV_ToDo
            // 
            LV_ToDo.AllowDrop = true;
            LV_ToDo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LV_ToDo.Location = new Point(1, 133);
            LV_ToDo.Name = "LV_ToDo";
            LV_ToDo.Size = new Size(351, 492);
            LV_ToDo.TabIndex = 8;
            LV_ToDo.UseCompatibleStateImageBehavior = false;
            LV_ToDo.View = View.List;
            LV_ToDo.ItemDrag += LV_ToDo_ItemDrag;
            LV_ToDo.DragDrop += LV_ToDo_DragDrop;
            LV_ToDo.DragEnter += LV_ToDo_DragEnter;
            LV_ToDo.KeyDown += LV_ToDo_KeyDown;
            // 
            // LV_ToDo_P
            // 
            LV_ToDo_P.AllowDrop = true;
            LV_ToDo_P.Location = new Point(360, 133);
            LV_ToDo_P.Name = "LV_ToDo_P";
            LV_ToDo_P.Size = new Size(371, 492);
            LV_ToDo_P.TabIndex = 9;
            LV_ToDo_P.UseCompatibleStateImageBehavior = false;
            LV_ToDo_P.View = View.List;
            LV_ToDo_P.ItemDrag += listView2_ItemDrag;
            LV_ToDo_P.DragDrop += listView2_DragDrop;
            LV_ToDo_P.DragEnter += listView2_DragEnter;
            LV_ToDo_P.KeyDown += LV_ToDo_KeyDown;
            // 
            // LV_ToDo_C
            // 
            LV_ToDo_C.AllowDrop = true;
            LV_ToDo_C.Location = new Point(738, 133);
            LV_ToDo_C.Name = "LV_ToDo_C";
            LV_ToDo_C.Size = new Size(326, 492);
            LV_ToDo_C.TabIndex = 10;
            LV_ToDo_C.UseCompatibleStateImageBehavior = false;
            LV_ToDo_C.View = View.List;
            LV_ToDo_C.ItemDrag += listView3_ItemDrag;
            LV_ToDo_C.DragDrop += listView3_DragDrop;
            LV_ToDo_C.DragEnter += listView3_DragEnter;
            LV_ToDo_C.KeyDown += LV_ToDo_KeyDown;
            // 
            // buttonDark
            // 
            buttonDark.FlatStyle = FlatStyle.Flat;
            buttonDark.Location = new Point(925, 15);
            buttonDark.Margin = new Padding(3, 4, 3, 4);
            buttonDark.Name = "buttonDark";
            buttonDark.Size = new Size(101, 31);
            buttonDark.TabIndex = 12;
            buttonDark.Text = "Темная тема";
            buttonDark.UseVisualStyleBackColor = true;
            buttonDark.Click += buttonDark_Click;
            // 
            // buttonPink
            // 
            buttonPink.FlatStyle = FlatStyle.Flat;
            buttonPink.Location = new Point(925, 64);
            buttonPink.Margin = new Padding(3, 4, 3, 4);
            buttonPink.Name = "buttonPink";
            buttonPink.Size = new Size(112, 31);
            buttonPink.TabIndex = 13;
            buttonPink.Text = "Розавая тема";
            buttonPink.UseVisualStyleBackColor = true;
            buttonPink.Click += buttonPink_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 651);
            Controls.Add(buttonPink);
            Controls.Add(buttonDark);
            Controls.Add(LV_ToDo_C);
            Controls.Add(LV_ToDo_P);
            Controls.Add(LV_ToDo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NewTaskbtn);
            Name = "Form1";
            Text = "ToDo";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewTaskbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView LV_ToDo;
        private ListView LV_ToDo_P;
        private ListView LV_ToDo_C;
        private Button buttonDark;
        private Button buttonPink;
    }
}