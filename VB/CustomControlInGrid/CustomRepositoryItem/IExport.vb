Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace CustomControlInGrid
	Public Interface IExport
		Function GetBrick(ByVal info As DevExpress.XtraEditors.PrintCellHelperInfo) As DevExpress.XtraPrinting.IVisualBrick
	End Interface
End Namespace
