window.onload = (event) => {
    const items = (() => {
        const fieldValue = localStorage.getItem('items');
        return fieldValue === null
          ? []
          : JSON.parse(fieldValue);
      })();
      
  };