namespace TextEditor
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.dictionary = new System.Windows.Forms.Button();
            this.newDocument = new System.Windows.Forms.Label();
            this.saveDocument = new System.Windows.Forms.Label();
            this.openDocument = new System.Windows.Forms.Label();
            this.deleteDocument = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyText = new System.Windows.Forms.Label();
            this.cutText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument = new System.Windows.Forms.Label();
            this.smallCaps = new System.Windows.Forms.Label();
            this.allCaps = new System.Windows.Forms.Label();
            this.underline = new System.Windows.Forms.Label();
            this.strikeout = new System.Windows.Forms.Label();
            this.italic = new System.Windows.Forms.Label();
            this.bold = new System.Windows.Forms.Label();
            this.smallerText = new System.Windows.Forms.Label();
            this.biggerText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorLetter = new System.Windows.Forms.Label();
            this.highlightLetter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.question = new System.Windows.Forms.Label();
            this.numberList = new System.Windows.Forms.Label();
            this.bulletList = new System.Windows.Forms.Label();
            this.alignRight = new System.Windows.Forms.Label();
            this.alignCenter = new System.Windows.Forms.Label();
            this.alignLeft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subscript = new System.Windows.Forms.Label();
            this.superscript = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clearAllFormating = new System.Windows.Forms.Label();
            this.insertTable = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.regular = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.wordList = new System.Windows.Forms.ListBox();
            this.checkBoxMissedLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxFromBeginning = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dictionary
            // 
            this.dictionary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dictionary.BackgroundImage")));
            this.dictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dictionary.Location = new System.Drawing.Point(724, 15);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(141, 66);
            this.dictionary.TabIndex = 1;
            this.dictionary.UseVisualStyleBackColor = true;
            this.dictionary.Click += new System.EventHandler(this.Dictionary_Click);
            // 
            // newDocument
            // 
            this.newDocument.Image = ((System.Drawing.Image)(resources.GetObject("newDocument.Image")));
            this.newDocument.Location = new System.Drawing.Point(12, 95);
            this.newDocument.Name = "newDocument";
            this.newDocument.Size = new System.Drawing.Size(27, 27);
            this.newDocument.TabIndex = 19;
            // 
            // saveDocument
            // 
            this.saveDocument.Image = ((System.Drawing.Image)(resources.GetObject("saveDocument.Image")));
            this.saveDocument.Location = new System.Drawing.Point(12, 176);
            this.saveDocument.Name = "saveDocument";
            this.saveDocument.Size = new System.Drawing.Size(27, 27);
            this.saveDocument.TabIndex = 20;
            this.saveDocument.Click += new System.EventHandler(this.SaveDocument_Click);
            // 
            // openDocument
            // 
            this.openDocument.Image = ((System.Drawing.Image)(resources.GetObject("openDocument.Image")));
            this.openDocument.Location = new System.Drawing.Point(12, 149);
            this.openDocument.Name = "openDocument";
            this.openDocument.Size = new System.Drawing.Size(27, 27);
            this.openDocument.TabIndex = 21;
            this.openDocument.Click += new System.EventHandler(this.OpenDocument_Click);
            // 
            // deleteDocument
            // 
            this.deleteDocument.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocument.Image")));
            this.deleteDocument.Location = new System.Drawing.Point(12, 122);
            this.deleteDocument.Name = "deleteDocument";
            this.deleteDocument.Size = new System.Drawing.Size(27, 27);
            this.deleteDocument.TabIndex = 22;
            this.deleteDocument.Click += new System.EventHandler(this.DeleteDocument_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 27);
            this.label2.TabIndex = 24;
            this.label2.Click += new System.EventHandler(this.PasteText_Click);
            // 
            // copyText
            // 
            this.copyText.Image = ((System.Drawing.Image)(resources.GetObject("copyText.Image")));
            this.copyText.Location = new System.Drawing.Point(12, 275);
            this.copyText.Name = "copyText";
            this.copyText.Size = new System.Drawing.Size(27, 27);
            this.copyText.TabIndex = 25;
            this.copyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // cutText
            // 
            this.cutText.Image = ((System.Drawing.Image)(resources.GetObject("cutText.Image")));
            this.cutText.Location = new System.Drawing.Point(12, 248);
            this.cutText.Name = "cutText";
            this.cutText.Size = new System.Drawing.Size(27, 27);
            this.cutText.TabIndex = 26;
            this.cutText.Click += new System.EventHandler(this.CutText_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 27;
            // 
            // printDocument
            // 
            this.printDocument.Image = ((System.Drawing.Image)(resources.GetObject("printDocument.Image")));
            this.printDocument.Location = new System.Drawing.Point(12, 205);
            this.printDocument.Name = "printDocument";
            this.printDocument.Size = new System.Drawing.Size(27, 27);
            this.printDocument.TabIndex = 28;
            this.printDocument.Click += new System.EventHandler(this.PrintDocument_Click);
            // 
            // smallCaps
            // 
            this.smallCaps.Image = ((System.Drawing.Image)(resources.GetObject("smallCaps.Image")));
            this.smallCaps.Location = new System.Drawing.Point(286, 54);
            this.smallCaps.Name = "smallCaps";
            this.smallCaps.Size = new System.Drawing.Size(27, 27);
            this.smallCaps.TabIndex = 29;
            this.smallCaps.Click += new System.EventHandler(this.SmallCaps_Click);
            // 
            // allCaps
            // 
            this.allCaps.Image = ((System.Drawing.Image)(resources.GetObject("allCaps.Image")));
            this.allCaps.Location = new System.Drawing.Point(253, 54);
            this.allCaps.Name = "allCaps";
            this.allCaps.Size = new System.Drawing.Size(27, 27);
            this.allCaps.TabIndex = 30;
            this.allCaps.Click += new System.EventHandler(this.AllCaps_Click);
            // 
            // underline
            // 
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.Location = new System.Drawing.Point(108, 54);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(27, 27);
            this.underline.TabIndex = 31;
            this.underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // strikeout
            // 
            this.strikeout.Image = ((System.Drawing.Image)(resources.GetObject("strikeout.Image")));
            this.strikeout.Location = new System.Drawing.Point(75, 54);
            this.strikeout.Name = "strikeout";
            this.strikeout.Size = new System.Drawing.Size(27, 27);
            this.strikeout.TabIndex = 32;
            this.strikeout.Click += new System.EventHandler(this.Strikeout_Click);
            // 
            // italic
            // 
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.Location = new System.Drawing.Point(42, 54);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(27, 27);
            this.italic.TabIndex = 33;
            this.italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // bold
            // 
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.Location = new System.Drawing.Point(12, 54);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(27, 27);
            this.bold.TabIndex = 34;
            this.bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // smallerText
            // 
            this.smallerText.Image = ((System.Drawing.Image)(resources.GetObject("smallerText.Image")));
            this.smallerText.Location = new System.Drawing.Point(367, 54);
            this.smallerText.Name = "smallerText";
            this.smallerText.Size = new System.Drawing.Size(27, 27);
            this.smallerText.TabIndex = 35;
            this.smallerText.Click += new System.EventHandler(this.SmallerText_Click);
            // 
            // biggerText
            // 
            this.biggerText.Image = ((System.Drawing.Image)(resources.GetObject("biggerText.Image")));
            this.biggerText.Location = new System.Drawing.Point(335, 54);
            this.biggerText.Name = "biggerText";
            this.biggerText.Size = new System.Drawing.Size(27, 27);
            this.biggerText.TabIndex = 36;
            this.biggerText.Click += new System.EventHandler(this.BiggerText_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(237, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 27);
            this.label3.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(319, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 27);
            this.label4.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(400, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 27);
            this.label6.TabIndex = 39;
            // 
            // ColorLetter
            // 
            this.ColorLetter.Image = ((System.Drawing.Image)(resources.GetObject("ColorLetter.Image")));
            this.ColorLetter.Location = new System.Drawing.Point(449, 54);
            this.ColorLetter.Name = "ColorLetter";
            this.ColorLetter.Size = new System.Drawing.Size(27, 27);
            this.ColorLetter.TabIndex = 40;
            this.ColorLetter.Click += new System.EventHandler(this.ColorLetter_Click);
            // 
            // highlightLetter
            // 
            this.highlightLetter.Image = ((System.Drawing.Image)(resources.GetObject("highlightLetter.Image")));
            this.highlightLetter.Location = new System.Drawing.Point(416, 54);
            this.highlightLetter.Name = "highlightLetter";
            this.highlightLetter.Size = new System.Drawing.Size(27, 27);
            this.highlightLetter.TabIndex = 41;
            this.highlightLetter.Click += new System.EventHandler(this.HighlightLetter_Click);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(400, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 27);
            this.label7.TabIndex = 42;
            // 
            // fontComboBox
            // 
            this.fontComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fontComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(15, 15);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(216, 28);
            this.fontComboBox.TabIndex = 43;
            this.fontComboBox.Text = "Microsoft Sans Serif";
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // fontSize
            // 
            this.fontSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.fontSize.Location = new System.Drawing.Point(240, 15);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(89, 28);
            this.fontSize.TabIndex = 44;
            this.fontSize.Text = "12";
            this.fontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // question
            // 
            this.question.Image = ((System.Drawing.Image)(resources.GetObject("question.Image")));
            this.question.Location = new System.Drawing.Point(12, 345);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(27, 27);
            this.question.TabIndex = 45;
            this.question.Click += new System.EventHandler(this.Question_Click);
            // 
            // numberList
            // 
            this.numberList.Image = ((System.Drawing.Image)(resources.GetObject("numberList.Image")));
            this.numberList.Location = new System.Drawing.Point(335, 16);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(27, 27);
            this.numberList.TabIndex = 46;
            this.numberList.Click += new System.EventHandler(this.NumberList_Click);
            // 
            // bulletList
            // 
            this.bulletList.Image = ((System.Drawing.Image)(resources.GetObject("bulletList.Image")));
            this.bulletList.Location = new System.Drawing.Point(367, 16);
            this.bulletList.Name = "bulletList";
            this.bulletList.Size = new System.Drawing.Size(27, 27);
            this.bulletList.TabIndex = 49;
            this.bulletList.Click += new System.EventHandler(this.BulletList_Click);
            // 
            // alignRight
            // 
            this.alignRight.Image = ((System.Drawing.Image)(resources.GetObject("alignRight.Image")));
            this.alignRight.Location = new System.Drawing.Point(482, 16);
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(27, 27);
            this.alignRight.TabIndex = 51;
            this.alignRight.Click += new System.EventHandler(this.AlignRight_Click);
            // 
            // alignCenter
            // 
            this.alignCenter.Image = ((System.Drawing.Image)(resources.GetObject("alignCenter.Image")));
            this.alignCenter.Location = new System.Drawing.Point(449, 15);
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(27, 27);
            this.alignCenter.TabIndex = 52;
            this.alignCenter.Click += new System.EventHandler(this.AlignCenter_Click);
            // 
            // alignLeft
            // 
            this.alignLeft.Image = ((System.Drawing.Image)(resources.GetObject("alignLeft.Image")));
            this.alignLeft.Location = new System.Drawing.Point(416, 16);
            this.alignLeft.Name = "alignLeft";
            this.alignLeft.Size = new System.Drawing.Size(27, 27);
            this.alignLeft.TabIndex = 53;
            this.alignLeft.Click += new System.EventHandler(this.AlignLeft_Click);
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(515, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 27);
            this.label8.TabIndex = 54;
            // 
            // subscript
            // 
            this.subscript.Image = ((System.Drawing.Image)(resources.GetObject("subscript.Image")));
            this.subscript.Location = new System.Drawing.Point(171, 54);
            this.subscript.Name = "subscript";
            this.subscript.Size = new System.Drawing.Size(27, 27);
            this.subscript.TabIndex = 55;
            this.subscript.Click += new System.EventHandler(this.Subscript_Click);
            // 
            // superscript
            // 
            this.superscript.Image = ((System.Drawing.Image)(resources.GetObject("superscript.Image")));
            this.superscript.Location = new System.Drawing.Point(204, 54);
            this.superscript.Name = "superscript";
            this.superscript.Size = new System.Drawing.Size(27, 27);
            this.superscript.TabIndex = 56;
            this.superscript.Click += new System.EventHandler(this.Superscript_Click);
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(564, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 27);
            this.label9.TabIndex = 57;
            // 
            // clearAllFormating
            // 
            this.clearAllFormating.Image = ((System.Drawing.Image)(resources.GetObject("clearAllFormating.Image")));
            this.clearAllFormating.Location = new System.Drawing.Point(531, 16);
            this.clearAllFormating.Name = "clearAllFormating";
            this.clearAllFormating.Size = new System.Drawing.Size(27, 27);
            this.clearAllFormating.TabIndex = 58;
            this.clearAllFormating.Click += new System.EventHandler(this.ClearAllFormating_Click);
            // 
            // insertTable
            // 
            this.insertTable.Image = ((System.Drawing.Image)(resources.GetObject("insertTable.Image")));
            this.insertTable.Location = new System.Drawing.Point(531, 54);
            this.insertTable.Name = "insertTable";
            this.insertTable.Size = new System.Drawing.Size(27, 27);
            this.insertTable.TabIndex = 59;
            this.insertTable.Click += new System.EventHandler(this.InsertTable_Click);
            // 
            // backgroundColor
            // 
            this.backgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("backgroundColor.Image")));
            this.backgroundColor.Location = new System.Drawing.Point(482, 54);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(27, 27);
            this.backgroundColor.TabIndex = 61;
            this.backgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(564, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 27);
            this.label10.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(515, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 27);
            this.label11.TabIndex = 63;
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(45, 95);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(851, 364);
            this.richTextBox.TabIndex = 64;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // regular
            // 
            this.regular.Image = ((System.Drawing.Image)(resources.GetObject("regular.Image")));
            this.regular.Location = new System.Drawing.Point(138, 54);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(27, 27);
            this.regular.TabIndex = 65;
            this.regular.Click += new System.EventHandler(this.Regular_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // wordList
            // 
            this.wordList.FormattingEnabled = true;
            this.wordList.Location = new System.Drawing.Point(100, 149);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(120, 95);
            this.wordList.TabIndex = 66;
            this.wordList.Visible = false;
            this.wordList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordList_KeyDown);
            // 
            // checkBoxMissedLetters
            // 
            this.checkBoxMissedLetters.AutoSize = true;
            this.checkBoxMissedLetters.Location = new System.Drawing.Point(580, 16);
            this.checkBoxMissedLetters.Name = "checkBoxMissedLetters";
            this.checkBoxMissedLetters.Size = new System.Drawing.Size(137, 17);
            this.checkBoxMissedLetters.TabIndex = 67;
            this.checkBoxMissedLetters.Text = "Check by missed letters";
            this.checkBoxMissedLetters.UseVisualStyleBackColor = true;
            this.checkBoxMissedLetters.CheckedChanged += new System.EventHandler(this.checkBoxMissedLetters_CheckedChanged);
            // 
            // checkBoxFromBeginning
            // 
            this.checkBoxFromBeginning.AutoSize = true;
            this.checkBoxFromBeginning.Location = new System.Drawing.Point(580, 41);
            this.checkBoxFromBeginning.Name = "checkBoxFromBeginning";
            this.checkBoxFromBeginning.Size = new System.Drawing.Size(108, 17);
            this.checkBoxFromBeginning.TabIndex = 68;
            this.checkBoxFromBeginning.Text = "Check if contains";
            this.checkBoxFromBeginning.UseVisualStyleBackColor = true;
            this.checkBoxFromBeginning.CheckedChanged += new System.EventHandler(this.checkBoxFromBeginning_CheckedChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 471);
            this.Controls.Add(this.checkBoxFromBeginning);
            this.Controls.Add(this.checkBoxMissedLetters);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.insertTable);
            this.Controls.Add(this.clearAllFormating);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.superscript);
            this.Controls.Add(this.subscript);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.alignLeft);
            this.Controls.Add(this.alignCenter);
            this.Controls.Add(this.alignRight);
            this.Controls.Add(this.bulletList);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.question);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.highlightLetter);
            this.Controls.Add(this.ColorLetter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.biggerText);
            this.Controls.Add(this.smallerText);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.strikeout);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.allCaps);
            this.Controls.Add(this.smallCaps);
            this.Controls.Add(this.printDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cutText);
            this.Controls.Add(this.copyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteDocument);
            this.Controls.Add(this.openDocument);
            this.Controls.Add(this.saveDocument);
            this.Controls.Add(this.newDocument);
            this.Controls.Add(this.dictionary);
            this.Name = "TextEditor";
            this.Text = "Ma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dictionary;
        private System.Windows.Forms.Label newDocument;
        private System.Windows.Forms.Label saveDocument;
        private System.Windows.Forms.Label openDocument;
        private System.Windows.Forms.Label deleteDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label copyText;
        private System.Windows.Forms.Label cutText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label printDocument;
        private System.Windows.Forms.Label smallCaps;
        private System.Windows.Forms.Label allCaps;
        private System.Windows.Forms.Label underline;
        private System.Windows.Forms.Label strikeout;
        private System.Windows.Forms.Label italic;
        private System.Windows.Forms.Label bold;
        private System.Windows.Forms.Label smallerText;
        private System.Windows.Forms.Label biggerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ColorLetter;
        private System.Windows.Forms.Label highlightLetter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.ComboBox fontSize;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label numberList;
        private System.Windows.Forms.Label bulletList;
        private System.Windows.Forms.Label alignRight;
        private System.Windows.Forms.Label alignCenter;
        private System.Windows.Forms.Label alignLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label subscript;
        private System.Windows.Forms.Label superscript;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label clearAllFormating;
        private System.Windows.Forms.Label insertTable;
        private System.Windows.Forms.Label backgroundColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label regular;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.CheckBox checkBoxMissedLetters;
        private System.Windows.Forms.CheckBox checkBoxFromBeginning;
    }
}

