document.getElementById("form").addEventListener("submit", function(event) {
    event.preventDefault(); // Prevenir la recarga de la página

    // Realizar la solicitud GET utilizando la API fetch
    fetch("https://localhost:44353/api/Productos", {
      method: "GET",
      headers: {
        "Content-Type": "application/json" // Establecer el encabezado para JSON (puede variar según la API)
      }
    })
      .then(function (response) {
        if (response.ok) {
          return response.json(); // Parsear la respuesta JSON
        } else {
          throw new Error("Error en la solicitud GET");
        }
      })
      .then(function (responseData) {
        // Manejar la respuesta de la API aquí
        console.log(responseData);
        // Aquí puedes actualizar la interfaz de usuario con los datos obtenidos, por ejemplo:
        // Mostrar los datos en una tabla o realizar otras acciones
      })
      .catch(function (error) {
        // Manejar errores aquí
        console.error(error);
      });
  });
