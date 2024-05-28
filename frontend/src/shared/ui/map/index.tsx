"use client";

import { APIProvider, Map, Marker } from "@vis.gl/react-google-maps";

export const MapGoogle = () => {
  const position = { lat: 53.908711158562255, lng: 27.57292936399445 }; //53.908711158562255, 27.57292936399445

  return (
    <APIProvider apiKey={"AIzaSyCeSxwUMXdBe2j-uQaAeb5djjF3AVJLVxI"}>
      <div style={{ height: "400px", width: "100%", marginTop: "50px" }}>
        <Map defaultCenter={position} defaultZoom={13}>
          <Marker position={position} />
        </Map>
      </div>
    </APIProvider>
  );
};
