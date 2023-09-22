document.getElementById("from").addEventListener("submit", function(event) {
    event.preventDefault();
    // Obtener el ID del producto que deseas eliminar (puedes adaptar esto según tu necesidad)

       // Obtener los valores de los campos del formulario
       var Nombre = document.getElementById("Nombre").value;
   
       // Crear un objeto de datos JSON que deseas enviar
       var data = {
         Nombre: Nombre
       };
    
    // Realizar la solicitud DELETE utilizando la API fetch
    fetch("https://localhost:44353/api/Productos", {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json" // Establecer el encabezado para JSON
      },
      body: JSON.stringify(data)
    })
      .then(function (response) {
        if (response.ok) {
          // El producto se eliminó correctamente
          console.log("Producto eliminado correctamente");
        } else {
          throw new Error("Error en la solicitud DELETE");
        }
      })
      .catch(function (error) {
        // Manejar errores aquí
        console.error(error);
      });
  });
  