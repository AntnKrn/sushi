"use client";

import { APIProvider, Map, Marker } from "@vis.gl/react-google-maps";

export const MapGoogle = () => {
  const position = { lat: 53.54992, lng: 10.00678 };

  return (
    <APIProvider apiKey={"AIzaSyCeSxwUMXdBe2j-uQaAeb5djjF3AVJLVxI"}>
      <div style={{ height: "400px", width: "100%", marginTop: "50px" }}>
        <Map defaultCenter={position} defaultZoom={10}>
          <Marker position={position} />
        </Map>
      </div>
    </APIProvider>
  );
};
