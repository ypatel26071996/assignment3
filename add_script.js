function addInfo(){
    let fname=document.getElementById("fname").value;
    let lname=document.getElementById("lname").value;
    let address=document.getElementById("address").value;
    let city=document.getElementById("city").value;
    let province=document.getElementById("province").value;
    let postalcode=document.getElementById("postalcode").value;
    let phone=document.getElementById("phone").value;
    let email=document.getElementById("email").value;
    let make=document.getElementById("make").value;
    let model=document.getElementById("model").value;
    let year=document.getElementById("year").value;
    let status=true;
    if(fname.length==0){
        document.getElementById("fname_status").innerHTML="*Required";
        status=false;
    }
    if(lname.length==0){
        document.getElementById("lname_status").innerHTML="*Required";
        status=false;
    }
    if(address.length==0){
        document.getElementById("address_status").innerHTML="*Required";
        status=false;
    }
     if(city.length==0){
        document.getElementById("city_status").innerHTML="*Required";
        status=false;
    }
    if(province.length==0){
        document.getElementById("province_status").innerHTML="*Required";
        status=false;
    }
    if(postalcode.length==0){
        document.getElementById("postalcode_status").innerHTML="*Required";
        status=false;
    }
     if(phone.length==0){
        document.getElementById("phone_status").innerHTML="*Required";
        status=false;
    }
     if(email.length==0){
        document.getElementById("email_status").innerHTML="*Required";
        status=false;
    }
     if(make.length==0){
        document.getElementById("make_status").innerHTML="*Required";
        status=false;
    }
     if(model.length==0){
        document.getElementById("model_status").innerHTML="*Required";
        status=false;
    } if(year.length==0){
        document.getElementById("year_status").innerHTML="*Required";
    } if(/^[(]{0,1}[0-9]{3}[)]{0,1}[-\s\.]{0,1}[0-9]{3}[-\s\.]{0,1}[0-9]{4}$/.test(phone)==false){
        document.getElementById("phone_status").innerHTML="*incorrect format";
        status=false;
    } if(/(^\d{5}$)|(^\d{5}-\d{4}$)/.test(postalcode)==false){
        document.getElementById("postal_status").innerHTML="*Incorrect format";
        status=false;
    }
    
    if(status){
        const items = (() => {
            const fieldValue = localStorage.getItem('items');
            return fieldValue === null
              ? []
              : JSON.parse(fieldValue);
          })();
        const info={
            _fname:fname,
            _lname:lname,
            _address:address,
            _city:city,
            _province:province,
            _postalcode:postalcode,
            _phone:phone,
            _email:email,
            _make:make,
            _model:model,
            _year:year
        }
        items.push(info);
        window.localStorage.setItem("items",JSON.stringify(items));
        alert("Info saved");
    }
}