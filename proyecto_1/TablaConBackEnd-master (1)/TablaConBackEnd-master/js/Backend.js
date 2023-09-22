// URL de la API que deseas consultar
const apiUrl = 'https://localhost:44353/api/Productos';

fetch(apiUrl)
  .then(response => {
    if (!response.ok) {
      throw new Error(`Error al obtener los datos. Código de estado: ${response.status}`);
    }
    return response.json();
  })
  .then(data => {
    console.log(data);
  })
  .catch(error => {
    console.error('Ha ocurrido un error:', error);
  });
