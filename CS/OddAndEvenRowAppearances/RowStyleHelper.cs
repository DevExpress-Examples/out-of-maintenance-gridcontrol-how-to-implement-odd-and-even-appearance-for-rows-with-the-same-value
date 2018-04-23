using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace OddAndEvenRowAppearances
{
    public class RowStyleHelper
    {
        private object previousValue;

        private bool isPreviousPaobjected;

        private string columnName;

        private Color rowColor = Color.Aqua;

        public Color RowColor
        {
            get { return rowColor; }
            set { rowColor = value; }
        }

        private GridView gridView;

        public GridView GrView
        {
            get { return gridView; }
            set { gridView = value; }
        }

        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        public RowStyleHelper(GridView gridView, string columnName)
        {
            GrView = gridView;
            ColumnName = columnName;
            Attach();
        }

        public void Attach()
        {
            GrView.RowStyle += GridView_RowStyle;
        }

        public void Detach()
        {
            GrView.RowStyle -= GridView_RowStyle;
        }

        private void GridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle == -1) return;

            object currentCellValue = view.GetRowCellValue(e.RowHandle, columnName);

            if (e.RowHandle == 0)
            {
                e.Appearance.BackColor = RowColor;
                isPreviousPaobjected = true;
                previousValue = currentCellValue;
                return;
            }
            isPreviousPaobjected = DetectPreviousRow(view, e.RowHandle);
            if (previousValue.Equals(currentCellValue))
            {
                if (isPreviousPaobjected) e.Appearance.BackColor = RowColor;
            }
            else
            {
                if (!isPreviousPaobjected)
                    e.Appearance.BackColor = RowColor;
            }
            previousValue = currentCellValue;
        }

        private bool DetectPreviousRow(GridView view, int rowHandle)
        {
            bool previuosRowIsPaobjected = true;
            object prevValue = view.GetRowCellValue(0, columnName);
            for (int i = 1; i < rowHandle; i++)
            {
                object tempCellValue = view.GetRowCellValue(i, columnName);

                if (!prevValue.Equals(tempCellValue))
                {
                    if (!previuosRowIsPaobjected) previuosRowIsPaobjected = true;
                    else previuosRowIsPaobjected = false;
                }
                prevValue = tempCellValue;
            }
            previousValue = prevValue;
            return previuosRowIsPaobjected;
        }
    }
}
