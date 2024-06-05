import React, { useState, useEffect } from 'react';
import axios from 'axios';

function Fetch() {
  const [Regions, setRegions] = useState([]);
  useEffect(() => {
    axios.get('http://localhost:5119/api/regions')
      .then(response => {
        setRegions(response);
        console.log(Regions);
      })
      .catch(error => {
        console.log(error);
      });
  }, []);

  return (
    <div>
       
      {/* {Regions.map(item => (
        <p key={item.regionCode}>{item.regionName}</p>
      ))} */}
    </div>
  );
}
export default Fetch;







// import { useState, useEffect } from 'react';
// // import axios from 'axios'
// // const Fetch = () => {
// //   // axios.get()
// //   const [Regions, setRegions] = useState([]);
// //   useEffect(() => {
// //     fetch('https://localhost:7074/api/regions', {
// //       method: 'GET',
// //       // withCredentials: true,
// //       // crossorigin: true,
// //       mode: 'no-cors'
// //     })
// //       .then((res) => {
// //         return res;
// //       })
// //       .then((data) => {
// //         console.log(data);
// //         setRegions(data);
// //       });
// //   }, []);
// //   return (
// //     Regions.json().map(region => (<div>{region.name}: {/*region.code*/}</div>))
// //   );
// // };


// export default Fetch;