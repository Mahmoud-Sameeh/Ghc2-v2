// ------------------------------start doctor page calender-----------------------------------//
//var date = new Date(); 
//var month = new Array();
//month[0] = "January";
//month[1] = "February";
//month[2] = "March";
//month[3] = "April";
//month[4] = "May";
//month[5] = "June";
//month[6] = "July";
//month[7] = "August";
//month[8] = "September";
//month[9] = "October";
//month[10] = "November";
//month[11] = "December";

//document.getElementById('yearCaption').innerHTML=date.getFullYear();
//document.getElementById('monthCaption').innerHTML=month[date.getMonth()];
//document.getElementById('dayCaption').innerHTML=date.getDate();
// ------------------------------End doctor page calender-----------------------------------//
// ------------------------------start side nav  controles-----------------------------------//
var profilecontainer=document.getElementById("profileContainer");
var appointmentContainer=document.getElementById("appointmentContainer");
var DoctorsContainer=document.getElementById("DoctorsContainer");
var PatientProfileShownByDoctor=document.getElementById("PatientProfileShownByDoctor");
var PatientsHistoryContainer=document.getElementById("PatientsHistoryContainer");
function profileAnchor()
{
profilecontainer.style.display="block";
appointmentContainer.style.display="none";
DoctorsContainer.style.display="none";
PatientsHistoryContainer.style.display="none";
PatientProfileShownByDoctor.style.display='none';

}
function appoientmentAnchor()
{
profilecontainer.style.display="none";
appointmentContainer.style.display="block";
PatientsHistoryContainer.style.display="none";
DoctorsContainer.style.display="none";
PatientProfileShownByDoctor.style.display='none';


}function doctorsAnchor()
{
appointmentContainer.style.display="none";
profilecontainer.style.display="none";
PatientsHistoryContainer.style.display="none";
DoctorsContainer.style.display="block";
PatientProfileShownByDoctor.style.display='none';

}
function patientHistoryAnchor()
{
appointmentContainer.style.display="none";
profilecontainer.style.display="none";
DoctorsContainer.style.display="none";
PatientsHistoryContainer.style.display="block";
PatientProfileShownByDoctor.style.display='none';


}
function chatAnchor()
{
appointmentContainer.style.display="none";
profilecontainer.style.display="none";
DoctorsContainer.style.display="none";
PatientsHistoryContainer.style.display="none";
PatientProfileShownByDoctor.style.display='none';


}
function settingAnchor()
{
appointmentContainer.style.display="none";
DoctorsContainer.style.display="none";
profilecontainer.style.display="none";
PatientsHistoryContainer.style.display="none";
PatientProfileShownByDoctor.style.display='none';

}
function logoutAnchor()
{
appointmentContainer.style.display="none";
DoctorsContainer.style.display="none";
profilecontainer.style.display="none";
PatientsHistoryContainer.style.display="none";
PatientProfileShownByDoctor.style.display='none';

}
// ------------------------------End side nav  controles-----------------------------------//

// ----------------------------------------- start  to do list ----------------------------//

// Create a "close" button and append it to each list item
var myNodelist = document.getElementsByTagName("LI");

var i;


for (i = 0; i < myNodelist.length; i++) {
    if(myNodelist[i].parentElement.className=='ToDo')
    {
  var span = document.createElement("SPAN");
  var txt = document.createTextNode("\u00D7");
  span.className = "close";

  span.appendChild(txt);
  myNodelist[i].appendChild(span);
}
}

// Click on a close button to hide the current list item
var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
  close[i].onclick = function() {
    var div = this.parentElement;
    div.style.display = "none";
  }
}



// Add a "checked" symbol when clicking on a list item
var list = document.getElementById('myUL')
list.addEventListener('click', function(ev) {
  if (ev.target.tagName === 'LI') {
    ev.target.classList.toggle('checked');
  }
}, false);

// Create a new list item when clicking on the "Add" button
function newElement() {
    var li = document.createElement("li");
    var inputValue = document.getElementById("myInput11").value;
    var t = document.createTextNode(inputValue);
    li.appendChild(t);
    if (inputValue === '') {
        alert("You must write something!");
    } else {
        document.getElementById("myUL").appendChild(li);
    }
    document.getElementById("myInput11").value = "";

    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    li.appendChild(span);

    for (i = 0; i < close.length; i++) {
        close[i].onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
        }
    }
}


// -----------------------------------------end to do list-----------------------------------//
// -----------------------------------------start appointment---------------------------//
function myFunction1() {//search on table function
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("myInput1");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable1");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
      td = tr[i].getElementsByTagName("td")[0];
      if (td) {
        txtValue = td.textContent || td.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
          tr[i].style.display = "";
        } else {
          tr[i].style.display = "none";
        }
      }       
    }
  }//end of search function
  // -----------------------------------------------------------patient hestorical data table//
  function txtSearchFunction1() {//search on table function
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("txtDeptSearch");
    filter = input.value.toUpperCase();
    table = document.getElementById("DiagnosesTBl");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
      td = tr[i].getElementsByTagName("td")[0];
      if (td) {
        txtValue = td.textContent || td.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
          tr[i].style.display = "";
        } else {
          tr[i].style.display = "none";
        }
      }       
    }
  }


  // -------------Action on details button--//
  var btnShowDiagonesDetails=document.getElementsByClassName('btnShowDiagonesDetails'); 
  var modalDataTargetID=document.getElementById("mdl");
  for(var x=0;x<btnShowDiagonesDetails.length;x++)
  {
    btnShowDiagonesDetails[x].onclick=function(){
  
     
      alert("hi");


    }}
  
  //  EndAction on details button-----//

  // ----------------------------------------------------------- end patient hestorical data table//

  var btnDteteRow=document.getElementsByClassName('btnDteteRow'); //start delete button function
var btnEnterId=document.getElementsByClassName('btnEnterId');//buttons for open enter id form
var patientIdForm=document.getElementById("patientIdForm");//patient id form 
var confirm=document.getElementById("confirm1");//confermation delete message
for(var x=0;x<btnDteteRow.length;x++)
{
  btnDteteRow[x].onclick=function(){
    // var btn=this.parentElement.parentElement.remove();
    //////////////////////////////////////////////////////////
    var z= this;
   
    confirm.style.display='block';
    patientIdForm.style.display='none';

//  var message1=document.getElementsByClassName("message1");
 var yes=document.getElementById("yes1");
 var No=document.getElementById("No1");
yes.onclick=function(){
     var btn=z.parentElement.parentElement.remove();
  console.log(z);

    confirm.style.display='none';

}
No.onclick=function(){
  confirm.style.display='none';
  patientIdForm.style.display='none';
}


  }
}//End delete button function 
//------------------------------------------------start  patientIdForm
console.log(btnEnterId);
for(var x=0;x<btnEnterId.length;x++)
{
  btnEnterId[x].onclick=function(){
  
    patientIdForm.style.display='block';
    confirm.style.display='none';
    
    var btnGo=document.getElementById("btnGo");
    var cancleId=document.getElementById("cancleId")
    var txtPatientId=document.getElementById("txtPatientId");
    btnGo.onclick=function(){
      console.log(txtPatientId.value);
        if(txtPatientId.value!="")
        {
      console.log(txtPatientId.value);
         
          // Search for patient Id in database and open his own page
          patientIdForm.style.display='none';
          PatientProfileShownByDoctor.style.display='block';
          appointmentContainer.style.display="none";
          DoctorsContainer.style.display="none";
          profilecontainer.style.display="none";
          PatientsHistoryContainer.style.display="none";
        }
        else{
          txtPatientId.style.border="2px solid red";
          txtPatientId.innerText=="";

        }
   }
   cancleId.onclick=function(){
    patientIdForm.style.display='none';
  confirm.style.display='none';
   
   }
   

  }
}
//------------------------------------------------End patientIdForm

//start confirm Delete fnc
// function functionAlert(msg, myYes) {
//   var confirmBox = $("#confirm");
//   confirmBox.find(".message").text(msg);
//   confirmBox.find(".yes").unbind().click(function() {
//      confirmBox.hide();
//   });
//   confirmBox.find(".yes").click(myYes);
//   confirmBox.show();
// }
// --------------------------------------------End appointment---------------------------//
// --------------------------------------------start diagonose medicin --------------------//
function filterFunction() {
  var input, filter, ul, li, a, i;
  input = document.getElementById("dropSearch");
  filter = input.value.toUpperCase();
  div = document.getElementById("myDropdown");
  a = div.getElementsByTagName("a");
  for (i = 0; i < a.length; i++) {
    txtValue = a[i].textContent || a[i].innerText;
    if (txtValue.toUpperCase().indexOf(filter) > -1) {
      a[i].style.display = "";
    } else {
      a[i].style.display = "none";
    }
  }
}
// --------------------------------------------End diagonose medicin --------------------//
