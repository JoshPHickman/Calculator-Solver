namespace SolverTest {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.solveButton = new System.Windows.Forms.Button();
            this.unsolvedEquation = new System.Windows.Forms.Label();
            this.solvedEquation = new System.Windows.Forms.Label();
            this.postEquationLabel = new System.Windows.Forms.Label();
            this.solvedIndecesLabel = new System.Windows.Forms.Label();
            this.multiplicationLabel = new System.Windows.Forms.Label();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.additionLabel = new System.Windows.Forms.Label();
            this.subtractionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(187, 190);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 0;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // unsolvedEquation
            // 
            this.unsolvedEquation.AutoSize = true;
            this.unsolvedEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsolvedEquation.Location = new System.Drawing.Point(94, 97);
            this.unsolvedEquation.Name = "unsolvedEquation";
            this.unsolvedEquation.Size = new System.Drawing.Size(0, 25);
            this.unsolvedEquation.TabIndex = 1;
            // 
            // solvedEquation
            // 
            this.solvedEquation.AutoSize = true;
            this.solvedEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvedEquation.Location = new System.Drawing.Point(598, 97);
            this.solvedEquation.Name = "solvedEquation";
            this.solvedEquation.Size = new System.Drawing.Size(18, 25);
            this.solvedEquation.TabIndex = 2;
            this.solvedEquation.Text = " ";
            // 
            // postEquationLabel
            // 
            this.postEquationLabel.AutoSize = true;
            this.postEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postEquationLabel.Location = new System.Drawing.Point(240, 140);
            this.postEquationLabel.Name = "postEquationLabel";
            this.postEquationLabel.Size = new System.Drawing.Size(0, 25);
            this.postEquationLabel.TabIndex = 2;
            // 
            // solvedIndecesLabel
            // 
            this.solvedIndecesLabel.AutoSize = true;
            this.solvedIndecesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvedIndecesLabel.Location = new System.Drawing.Point(182, 239);
            this.solvedIndecesLabel.Name = "solvedIndecesLabel";
            this.solvedIndecesLabel.Size = new System.Drawing.Size(0, 25);
            this.solvedIndecesLabel.TabIndex = 2;
            // 
            // multiplicationLabel
            // 
            this.multiplicationLabel.AutoSize = true;
            this.multiplicationLabel.Location = new System.Drawing.Point(64, 275);
            this.multiplicationLabel.Name = "multiplicationLabel";
            this.multiplicationLabel.Size = new System.Drawing.Size(26, 13);
            this.multiplicationLabel.TabIndex = 3;
            this.multiplicationLabel.Text = "mult";
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Location = new System.Drawing.Point(64, 307);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(28, 13);
            this.divisionLabel.TabIndex = 3;
            this.divisionLabel.Text = "divis";
            // 
            // additionLabel
            // 
            this.additionLabel.AutoSize = true;
            this.additionLabel.Location = new System.Drawing.Point(64, 334);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(25, 13);
            this.additionLabel.TabIndex = 3;
            this.additionLabel.Text = "add";
            // 
            // subtractionLabel
            // 
            this.subtractionLabel.AutoSize = true;
            this.subtractionLabel.Location = new System.Drawing.Point(64, 366);
            this.subtractionLabel.Name = "subtractionLabel";
            this.subtractionLabel.Size = new System.Drawing.Size(30, 13);
            this.subtractionLabel.TabIndex = 3;
            this.subtractionLabel.Text = "subtr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 491);
            this.Controls.Add(this.subtractionLabel);
            this.Controls.Add(this.additionLabel);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.multiplicationLabel);
            this.Controls.Add(this.solvedIndecesLabel);
            this.Controls.Add(this.postEquationLabel);
            this.Controls.Add(this.solvedEquation);
            this.Controls.Add(this.unsolvedEquation);
            this.Controls.Add(this.solveButton);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label unsolvedEquation;
        private System.Windows.Forms.Label solvedEquation;
        private System.Windows.Forms.Label postEquationLabel;
        private System.Windows.Forms.Label solvedIndecesLabel;
        private System.Windows.Forms.Label multiplicationLabel;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.Label additionLabel;
        private System.Windows.Forms.Label subtractionLabel;
    }
}

