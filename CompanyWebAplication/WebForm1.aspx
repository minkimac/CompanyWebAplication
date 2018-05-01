<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyWebAplication.WebForm1" %>

<asp:Content ID="Carousel1" ContentPlaceHolderID="Carousel1" runat="server">
    <div id="carousel1" class="carousel slide" data-ride="carousel">

          <!-- Indicators -->
          <ul class="carousel-indicators">
            <li data-target="#carousel1" data-slide-to="0" class="active"></li>
            <li data-target="#carousel1" data-slide-to="1"></li>
            <li data-target="#carousel1" data-slide-to="2"></li>
          </ul>

          <!-- The slideshow -->
          <div class="carousel-inner">
            <div class="carousel-item active">
              <img src="http://hdwbay.com/wp-content/uploads/2017/12/green-tree-nature-image-1920x768.jpg" alt="Los Angeles">
            </div>
            <div class="carousel-item">
              <img src="https://lh4.googleusercontent.com/-TqtuxOXaAOE/UMhTUoxZggI/AAAAAAAABzY/lBP6hIS58hw/s1366/QTBN1-1366x546.jpg" alt="Chicago">
            </div>
            <div class="carousel-item">
              <img src="http://img1.tebyan.net/Big/1389/10/4524223416318023211612043816510144533166.jpg" alt="New York">
            </div>
          </div>

          <!-- Left and right controls -->
          <a class="carousel-control-prev" href="#carousel1" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
          </a>
          <a class="carousel-control-next" href="#carousel1" data-slide="next">
            <span class="carousel-control-next-icon"></span>
          </a>
    </div>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Carousel2" runat="server">
    <div id="demo" class="carousel slide" data-ride="carousel">

          <!-- Indicators -->
          <ul class="carousel-indicators">
            <li data-target="#demo" data-slide-to="0" class="active"></li>
            <li data-target="#demo" data-slide-to="1"></li>
            <li data-target="#demo" data-slide-to="2"></li>
          </ul>

          <!-- The slideshow -->
          <div class="carousel-inner">
            <div class="row">
            <div class="col-sm-4">
              <div class="card testimonial">
                  <h3 class="testimonial-header">Name 1</h3>
                  <div class="testimonial-content">
                      vfvbdvhbhjsbvhjasbvhjbvhjsbvhjsbvhjsbdvhjbsvhjsvbshjvbbvjsdbvlsvjhbsvjlsbvhjbsvvldvsdvvvbreberbereebebrerberberabae
                  </div>
                </div>
            </div>
            <div class="col-sm-4">
              <div class="card testimonial">
                  <h3 class="testimonial-header">Name 2</h3>
                  <div class="testimonial-content">
                      vfvbdvhbhjsbvhjasbvhjbvhjsbvhjsbvhjsbdvhjbsvhjsvbshjvbbvjsdbvlsvjhbsvjlsbvhjbsvvldvsdvvvbreberbereebebrerberberabae
                  </div>
                </div>
            </div>
            <div class="col-sm-4">
                <div class="card testimonial">
                  <h3 class="testimonial-header">Name 3</h3>
                  <div class="testimonial-content">
                      vfvbdvhbhjsbvhjasbvhjbvhjsbvhjsbvhjsbdvhjbsvhjsvbshjvbbvjsdbvlsvjhbsvjlsbvhjbsvvldvsdvvvbreberbereebebrerberberabae
                  </div>
                </div>
            </div>
          </div>
          </div>

          <!-- Left and right controls -->
          <a class="carousel-control-prev" href="#demo" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
          </a>
          <a class="carousel-control-next" href="#demo" data-slide="next">
            <span class="carousel-control-next-icon"></span>
          </a>
    </div>
</asp:Content>

<%--<asp:Content ID="Content2" ContentPlaceHolderID="OTPBoxHolder" runat="server">
    <div class="row">
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP1" />
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP2" />
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP3" />
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP4" />
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP5" />
        <input type="text" class="form-control otpTextBox" runat="server" id="txtOTP6" />
    </div>
</asp:Content>--%>