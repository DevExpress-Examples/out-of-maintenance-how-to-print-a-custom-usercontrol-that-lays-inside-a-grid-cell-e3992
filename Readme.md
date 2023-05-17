<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630744/23.1.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3992)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomControl.cs](./CS/CustomControlInGrid/CustomRepositoryItem/CustomControl.cs) (VB: [CustomControl.vb](./VB/CustomControlInGrid/CustomRepositoryItem/CustomControl.vb))
* [CustomControlPainter.cs](./CS/CustomControlInGrid/CustomRepositoryItem/CustomControlPainter.cs) (VB: [CustomControlPainter.vb](./VB/CustomControlInGrid/CustomRepositoryItem/CustomControlPainter.vb))
* [CustomControlViewInfo.cs](./CS/CustomControlInGrid/CustomRepositoryItem/CustomControlViewInfo.cs) (VB: [CustomControlViewInfo.vb](./VB/CustomControlInGrid/CustomRepositoryItem/CustomControlViewInfo.vb))
* [CustomRepositoryItem.cs](./CS/CustomControlInGrid/CustomRepositoryItem/CustomRepositoryItem.cs) (VB: [CustomRepositoryItem.vb](./VB/CustomControlInGrid/CustomRepositoryItem/CustomRepositoryItem.vb))
* [EditorFinder.cs](./CS/CustomControlInGrid/CustomRepositoryItem/EditorFinder.cs) (VB: [EditorFinder.vb](./VB/CustomControlInGrid/CustomRepositoryItem/EditorFinder.vb))
* [IEditValue.cs](./CS/CustomControlInGrid/CustomRepositoryItem/IEditValue.cs) (VB: [IEditValue.vb](./VB/CustomControlInGrid/CustomRepositoryItem/IEditValue.vb))
* [IExport.cs](./CS/CustomControlInGrid/CustomRepositoryItem/IExport.cs) (VB: [IExport.vb](./VB/CustomControlInGrid/CustomRepositoryItem/IExport.vb))
* [Form1.cs](./CS/CustomControlInGrid/Form1.cs) (VB: [Form1.vb](./VB/CustomControlInGrid/Form1.vb))
* [Program.cs](./CS/CustomControlInGrid/Program.cs) (VB: [Program.vb](./VB/CustomControlInGrid/Program.vb))
* [ProjectLayoutControl.cs](./CS/CustomControlInGrid/ProjectLayoutControl.cs) (VB: [ProjectLayoutControl.vb](./VB/CustomControlInGrid/ProjectLayoutControl.vb))
<!-- default file list end -->
# How to print a custom UserControl that lays inside a grid cell


<p>This example illustrates how to print the content of a UserControl that is located within a grid cell. It extends the <a href="https://www.devexpress.com/Support/Center/p/E3051">How to put a custom UserControl in a GridView cell</a> example. The content of a UserControl can be printed. The UserControl must implement the IExport interface. This interface exposes the GetBrick method. The UserControl must draw the required layout in this method.</p>

<br/>


