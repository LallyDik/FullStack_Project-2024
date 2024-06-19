import React, { useState, useEffect } from 'react';
import axios from 'axios';

const SearchFilters = ({ onSearch }) => {
  const [locations, setLocations] = useState([]);
  const [location, setLocation] = useState('');
  const [stars, setStars] = useState('');
  const [price, setPrice] = useState('');
  const [beds, setBeds] = useState(1);

  useEffect(() => {
    const fetchLocations = async () => {
      try {
        const response = await axios.get('https://localhost:7074/api/regions');
        setLocations(response.data);
      } catch (error) {
        console.error('Error fetching locations:', error);
      }
    };

    fetchLocations();
  }, []);

  const handleSearch = () => {
    onSearch({ location, stars, price, beds });
    
  };

  return (
    <div className="search-filters">
      <label>
        Location:
        <select value={location} onChange={(e) => setLocation(e.target.value)}>
          <option value="">Select Location</option>
          {locations.map((loc) => (
            <option key={loc.regionCode} value={loc.regionCode}>{loc.regionName}</option>
          ))}
        </select>
      </label>
      <label>
          Stars:
          <input type="number" min="1" max="5" value={stars} onChange={(e) => setStars(e.target.value)} />
      </label>
      <label>
       Max Price:
      <input type="text" value={price} onChange={(e) => setPrice(e.target.value)} />
      </label>
      <label>
        Number of Beds:
        <input type="number" min="1" value={beds} onChange={(e) => setBeds(e.target.value)} />
      </label>
      <button onClick={handleSearch}>Search</button>
    </div>
);
};

export default SearchFilters;