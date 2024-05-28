import React, { useEffect, useState } from "react";
import "./index.scss";
import { MenuItem } from "../../../entities/menuItem";
import { search } from "../../../shared/api/menu";
import { IMenu } from "../../../shared/interfaces/IMenu";

export const Menu = () => {
  const [resultData, setResultData] = useState<IMenu[]>();

  useEffect(() => {
    (async function () {
      const result = await search("menu?PageSize=4");
      if (typeof result === "string") {
        console.log("error");
      } else if (Array.isArray(result.data)) {
        setResultData(result.data);
      }
    })();
  }, []);
  return (
    <div className="menu">
      <h2 style={{ textAlign: "center", padding: "30px 0", marginTop: "0" }}>
        Популярное
      </h2>
      <div className="menu-list">
        {resultData?.map((item, index) => {
          return (
            <MenuItem
              id={item.id}
              key={index}
              name={item.name}
              ingredients={item.ingredients}
              price={item.price}
              imgUrl={item.imgUrl}
            />
          );
        })}
      </div>
    </div>
  );
};
