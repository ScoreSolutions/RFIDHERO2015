<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>

<body>
    <form id="form1" runat="server">

        <div>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="5000"></asp:Timer>
            <asp:TextBox ID="txtCount" runat="server" Visible="false"></asp:TextBox>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table id="table1" runat="server" style="height: 1060px; width: 100%; background-image: url(image/BGfullhd.jpg);" cellpadding="0" cellspacing="0">
                        <tr style="height: 120px; width: 100%;">
                            <td>
                                <asp:Image ID="Image2" runat="server" Height="120px" ImageUrl="~/image/Header.png" />
                            </td>
                        </tr>
                        <tr style="height: 860px; width: 100%; vertical-align: top">
                            <td align="center">


                                <table style="height: 860px; width: 100%;" >
                                    <tr style="height: 430px;">


                                        <td style="height: 430px; width: 50%;">
                                            <table style="height: 430px; width: 100%;display:none" id="table_sub1_Type1" runat="server" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="80%" Height="300px" ID="PictureBoxImage1_Type1" runat="server" ImageUrl="~/image/bg.jpg" />





                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 80%; background-color: lightsteelblue;" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname1_type1" runat="server" Text=""></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h2>
                                                                        <asp:Label ID="lbldetail1_type1" runat="server" Text=""></asp:Label></h2>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                        <td style="height: 430px; width: 50%;">

                                            <table style="height: 430px; width: 100%;display:none" id="table_sub2_Type1" runat="server" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="80%" Height="300px" ID="PictureBoxImage2_Type1" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 80%; background-color: lightsteelblue;" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname2_type1" runat="server" Text=""></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h2>
                                                                        <asp:Label ID="lbldetail2_type1" runat="server" Text=""></asp:Label></h2>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>
                                        </td>
                             
                                    </tr>
                                    <tr style="height: 430px;">
                                        <td style="height: 430px; width: 50%;">
                                            <table style="height: 430px; width: 100%;display:none " id="table_sub3_Type1" runat="server" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="80%" Height="300px" ID="PictureBoxImage3_Type1" runat="server" ImageUrl="~/image/bg.jpg" />



                                                    </td>

                                                </tr>
                                                <tr>

                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 80%; background-color: lightsteelblue;" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname3_type1" runat="server" Text=""></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h2>
                                                                        <asp:Label ID="lbldetail3_type1" runat="server" Text=""></asp:Label></h2>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                        <td style="height: 450px; width: 50%;">


                                            <table style="height: 430px; width: 100%;display:none " id="table_sub4_Type1" runat="server" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="80%" Height="300px" ID="PictureBoxImage4_Type1" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 80%; background-color: lightsteelblue;" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname4_type1" runat="server" Text=""></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h2>
                                                                        <asp:Label ID="lbldetail4_type1" runat="server" Text=""></asp:Label></h2>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>


                                        </td>
                  
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table id="table2" runat="server" style="height: 1060px; width: 100%; background-image: url(image/BGfullhd.jpg);" cellpadding="0" cellspacing="0">
                        <tr style="height: 120px; width: 100%;">
                            <td>
                                <asp:Image ID="Image1" runat="server" Height="120px" ImageUrl="~/image/Header.png" />
                            </td>
                        </tr>
                        <tr style="height: 860px; width: 100%; vertical-align: top">
                            <td align="center">


                                <table style="height: 860px; width: 100%;" cellpadding="0" cellspacing="0">
                                    <tr style="height: 430px;">


                                        <td style="height: 430px; width: 25%;">
                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub1_Type2" runat="server" >
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage1_Type2" runat="server" ImageUrl="~/image/bg.jpg" />





                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;" >
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname1_type2" runat="server" Text="" Font-Size="35px" ></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail1_type2" runat="server" Text="" ></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                        <td style="height: 430px; width: 25%;">

                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub2_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage2_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname2_type2" runat="server" Text="" Font-Size="35px" ></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail2_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>
                                        </td>
                                        <td style="height: 430px; width: 25%;">

                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub3_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage3_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname3_type2" runat="server" Text="" Font-Size="35px"></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail3_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>
                                        </td>
                                        <td style="height: 430px; width: 25%;">
                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub4_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage4_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center" >
                                                                    <h1>
                                                                        <asp:Label ID="lblname4_type2" runat="server" Text="" Font-Size="35px"></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail4_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                    <tr style="height: 430px;">
                                        <td style="height: 430px; width: 25%;">
                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub5_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage5_Type2" runat="server" ImageUrl="~/image/bg.jpg" />



                                                    </td>

                                                </tr>
                                                <tr>

                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname5_type2" runat="server" Text="" Font-Size="35px"></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail5_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                        <td style="height: 450px; width: 25%;">


                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub6_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage6_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname6_type2" runat="server" Text="" Font-Size="35px"></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail6_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>


                                        </td>
                                        <td style="height: 450px; width: 25%;">
                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub7_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage7_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname7_type2" runat="server" Text="" Font-Size="35px"></asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail7_type2" runat="server" Text=""></asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                        <td style="height: 450px; width: 25%;">
                                            <table style="height: 430px; width: 100%; display: none;" id="table_sub8_Type2" runat="server">
                                                <tr>
                                                    <td style="height: 300px; width: 100%;" align="center">

                                                        <asp:Image Width="90%" Height="300px" ID="PictureBoxImage8_Type2" runat="server" ImageUrl="~/image/bg.jpg" />




                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td style="height: 120px; width: 100%;" align="center">
                                                        <table style="height: 100px; width: 90%; background-color: lightsteelblue;">
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h1>
                                                                        <asp:Label ID="lblname8_type2" runat="server" Text="" Font-Size="35px">&nbsp;</asp:Label></h1>
                                                                </td>

                                                            </tr>
                                                            <tr>
                                                                <td style="height: 50px; width: 100%;" align="center">
                                                                    <h3>
                                                                        <asp:Label ID="lbldetail8_type2" runat="server" Text="">&nbsp;</asp:Label></h3>

                                                                </td>

                                                            </tr>
                                                        </table>

                                                    </td>

                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>


        </div>
    </form>
</body>




</html>
