﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseTestCurriculum.aspx.cs" Inherits="ZYNLPJXT.ChooseTestCurriculum1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>选择测试课程</title>
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>

<body class="easyui-layout">


<div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'kcmc'" width="50">课程名称</th>
                <th data-options="field:'kcxzmc'" width="50">课程性质</th>
                <th data-options="field:'jzxq'" width="50">截止学期</th>
                <th data-options="field:'ycts'" width="50">已测题数</th>
    			<th data-options="field:'kcjj'" width="50">课程简介</th>
                <th data-options="field:'button'" width="30"></th>
    			
    		</tr>
    	</thead>
   		<tbody >
           
    		
              <%
              for (int i = 0; i < this.jdkcxsviews.Length; i++)
              {
              Response.Write("<tr >");
              Response.Write("	<td >" + jdkcxsviews[i].Kcmc  + "</td>");
    		  Response.Write("	<td >"+jdkcxsviews[i].Kcxzmc+"</td>");
    		  Response.Write("	<td >"+jdkcxsviews[i].Jzxq+"</td>");
              Response.Write("  <td >"+testNum[i]+"</td>");
              Response.Write("  <td >"+jdkcxsviews[i].Kcjj+"</td>");
              Response.Write("  <td><a id=\"A1\" href=\"#\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\"onclick=\"window.location.href='processAspx/GetTest.aspx?kcbh="+jdkcxsviews[i].Kcbh+"'\" >进入测试</a></td>");
              Response.Write("</tr>");
                 
              } %>
               
          
            
            
    	</tbody>
   	</table>     
</div>

 
                
<script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            pagination: true,
            //data:[{code:'1',price:'2',name:'dd'}],
            //url:'data.json',
            singleSelect: true
        });
    });

</script>

</body>

</html>