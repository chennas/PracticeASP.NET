<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accordion.aspx.cs" Inherits="GetClientLocation.Accordion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<%--    <div id="accordion" class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a href="#panelBodyOne" data-toggle="collapse" data-parent="#accordion">Asia
                    </a>
                </h4>
            </div>
            <div id="panelBodyOne" class="panel-collapse collapse in">
                <div class="panel-body">
                    <ul>
                        <li>India
                        </li>
                        <li>China
                        </li>
                        <li>Japan
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">
                <h4 class="panel-title">
                    <a href="#panelBodyTwo" data-toggle="collapse" data-parent="#accordion">Europe
                    </a>
                </h4>
            </div>
            <div id="panelBodyTwo" class="panel-collapse collapse">
                <div class="panel-body">
                    <ul>
                        <li>United Kingdom
                        </li>
                        <li>France
                        </li>
                        <li>Germany
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>--%>

    <div id="accordion" class="panel-group">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h4 class="panel-title">
                <a href="#panelBodyOne" data-toggle="collapse" data-parent="#accordion">
                    Asia
                </a>
            </h4>
        </div>
        <div id="panelBodyOne" class="panel-collapse collapse in">
            <div class="panel-body">
                <ul>
                    <li>India</li>
                    <li>China</li>
                    <li>Japan</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h4 class="panel-title">
                <a href="#panelBodyTwo" data-toggle="collapse" data-parent="#accordion">
                    Europe
                </a>
            </h4>
        </div>
        <div id="panelBodyTwo" class="panel-collapse collapse">
            <div class="panel-body">
                <ul>
                    <li>United Kingdom</li>
                    <li>France</li>
                    <li>Germany</li>
                </ul>

            </div>
        </div>
    </div>
    <div class="panel panel-primary">
        <div class="panel-heading">
            <h4 class="panel-title">
                <a href="#panelBodyThree" data-toggle="collapse" data-parent="#accordion">
                    North America
                </a>
            </h4>
        </div>
        <div id="panelBodyThree" class="panel-collapse collapse">
            <div class="panel-body">
                <ul>
                    <li>USA</li>
                    <li>Canada</li>
                    <li>Mexico</li>
                </ul>
            </div>
        </div>
    </div>
</div>
</asp:Content>
