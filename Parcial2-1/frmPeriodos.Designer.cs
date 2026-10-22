namespace Parcial2_1
{
    partial class frmPeriodos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.periodosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.periodosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.lblIdPeriodo = new System.Windows.Forms.Label();
            this.idPeriodoLabel1 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.periodoTextBox = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            this.periodosBindingNavigator.SuspendLayout();
            this.grbPeriodo.SuspendLayout();
            this.SuspendLayout();

            this.periodosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.periodosBindingNavigatorSaveItem});
            this.periodosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.periodosBindingNavigator.BackColor = System.Drawing.Color.White;
            this.periodosBindingNavigator.BindingSource = this.periodosBindingSource;
            this.periodosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.periodosBindingNavigator.CountItemFormat = "de {0}";
            this.periodosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.periodosBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.periodosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.periodosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.periodosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.periodosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.periodosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.periodosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.periodosBindingNavigator.Size = new System.Drawing.Size(460, 27);
            this.periodosBindingNavigator.TabIndex = 0;
            this.periodosBindingNavigator.Name = "periodosBindingNavigator";

            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveFirstItem.Text = "|<";
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";

            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMovePreviousItem.Text = "<";
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";

            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";

            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";

            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";

            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";

            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveNextItem.Text = ">";
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";

            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveLastItem.Text = ">|";
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";

            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";

            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";

            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";

            this.periodosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.periodosBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodosBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.periodosBindingNavigatorSaveItem.Text = "Guardar";
            this.periodosBindingNavigatorSaveItem.Name = "periodosBindingNavigatorSaveItem";
            this.periodosBindingNavigatorSaveItem.Click += new System.EventHandler(this.periodosBindingNavigatorSaveItem_Click);

            this.grbPeriodo.Controls.Add(this.fechaDateTimePicker);
            this.grbPeriodo.Controls.Add(this.lblFecha);
            this.grbPeriodo.Controls.Add(this.periodoTextBox);
            this.grbPeriodo.Controls.Add(this.lblPeriodo);
            this.grbPeriodo.Controls.Add(this.idPeriodoLabel1);
            this.grbPeriodo.Controls.Add(this.lblIdPeriodo);
            this.grbPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.grbPeriodo.Location = new System.Drawing.Point(16, 40);
            this.grbPeriodo.Size = new System.Drawing.Size(428, 158);
            this.grbPeriodo.TabIndex = 1;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Datos del período";
            this.grbPeriodo.Name = "grbPeriodo";

            this.lblIdPeriodo.AutoSize = true;
            this.lblIdPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblIdPeriodo.Location = new System.Drawing.Point(20, 34);
            this.lblIdPeriodo.Text = "ID:";
            this.lblIdPeriodo.Name = "lblIdPeriodo";

            this.idPeriodoLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.idPeriodoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPeriodoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.idPeriodoLabel1.Location = new System.Drawing.Point(130, 31);
            this.idPeriodoLabel1.Size = new System.Drawing.Size(90, 25);
            this.idPeriodoLabel1.Text = "";
            this.idPeriodoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idPeriodoLabel1.Name = "idPeriodoLabel1";

            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPeriodo.Location = new System.Drawing.Point(20, 72);
            this.lblPeriodo.Text = "Período:";
            this.lblPeriodo.Name = "lblPeriodo";

            this.periodoTextBox.Location = new System.Drawing.Point(130, 69);
            this.periodoTextBox.MaxLength = 30;
            this.periodoTextBox.Size = new System.Drawing.Size(270, 25);
            this.periodoTextBox.TabIndex = 0;
            this.periodoTextBox.Name = "periodoTextBox";

            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFecha.Location = new System.Drawing.Point(20, 110);
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Name = "lblFecha";

            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(130, 107);
            this.fechaDateTimePicker.Size = new System.Drawing.Size(140, 25);
            this.fechaDateTimePicker.TabIndex = 1;
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(460, 214);
            this.Controls.Add(this.grbPeriodo);
            this.Controls.Add(this.periodosBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periodos - USTR081726";
            this.Name = "frmPeriodos";
            this.Load += new System.EventHandler(this.frmPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            this.periodosBindingNavigator.ResumeLayout(false);
            this.periodosBindingNavigator.PerformLayout();
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.BindingNavigator periodosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton periodosBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.Label lblIdPeriodo;
        private System.Windows.Forms.Label idPeriodoLabel1;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox periodoTextBox;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource periodosBindingSource;
    }
}
