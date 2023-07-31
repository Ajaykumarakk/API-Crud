
//get user data function
function Vegdata()
{
    debugger;
    alert("hello working");
    var Vegetablename = document.getElementById("vegname");
    var vegname = Vegetablename.value;

    var ownername = document.getElementById("owner");
    var owner = ownername.value;

    var Quantity = document.getElementById("Quantity");
    var Quantity = Quantity.value;

    var Price = document.getElementById("Price");
    var Price = Price.value;

    var Location = document.getElementById("Location");
    var Location = Location.value;


    var morf = document.getElementsByName('gender');
    for (i = 0; i < morf.length; i++) 
    {
        if (morf[i].checked)
           {
            var malefe= morf[i].value;
           }
    }


          var checkboxes =document.getElementsByName('Veg');
          var result = "";
          for (var i = 0; i < checkboxes.length; i++) 
          {
            if (checkboxes[i].checked) 
               {
                result = checkboxes[i].value;
               }
            }

            const schooldata={
                Vegetablename:vegname.value,
                ownername:owner.value,
                Quantity:Quantity.value,
                Price:Price.value,
                Location:Location.value
            }
}
