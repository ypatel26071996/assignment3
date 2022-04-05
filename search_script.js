window.onload = (event) => {
    const items = (() => {
        const fieldValue = localStorage.getItem('items');
        return fieldValue === null
          ? []
          : JSON.parse(fieldValue);
      })();
      let table=document.getElementById("items").getElementsByTagName("tbody")[0];
      table.innerHTML="";
      items.forEach(item => {
          let newRow=table.insertRow();
          let nameCell=newRow.insertCell(0);
          let addressCell=newRow.insertCell(1);
          let cityCell=newRow.insertCell(2);
          let provinceCell=newRow.insertCell(3);
          let postalcodeCell=newRow.insertCell(4);
          let phoneCell=newRow.insertCell(5);
          let emailCell=newRow.insertCell(6);
          let makeCell=newRow.insertCell(7);
          let modelCell=newRow.insertCell(8);
          let yearCell=newRow.insertCell(9);
          let linkCell=newRow.insertCell(10);

          nameCell.appendChild(document.createTextNode(item._fname+" "+item._lname));
          addressCell.appendChild(document.createTextNode(item._adress));
          cityCell.appendChild(document.createTextNode(item._city));
          provinceCell.appendChild(document.createTextNode(item._province));
          postalcodeCell.appendChild(document.createTextNode(item._postalcode));
          phoneCell.appendChild(document.createTextNode(item._phone));
          emailCell.appendChild(document.createTextNode(item._email));
          makeCell.appendChild(document.createTextNode(item._make));
          modelCell.appendChild(document.createTextNode(item._model));
          yearCell.appendChild(document.createTextNode(item._year));
          let link='<a href="http://www.jdpower.com/cars/'+item._make+'/'+item._model+'/'+item._year+'" target="_blank">View</a>';
          linkCell.innerHTML=link;
          
      });
  };