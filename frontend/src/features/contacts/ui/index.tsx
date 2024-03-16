import React from "react";

import { Logo } from "../../../shared/ui/logo";
import "./index.scss";
import { MapPoint } from "../../../shared/ui/mapPoint";
import { Clock } from "../../../shared/ui/clock";
import { Email } from "../../../shared/ui/email";
import { Phone } from "../../../shared/ui/phone";

export const Contacts = () => {
  return (
    <div className="Contacts">
      <div className="contact item side left">
        <h6>
          <Clock />
          &nbsp;10:00-22:00
        </h6>
        <h6>
          <MapPoint />
          Mira str., Minsk
        </h6>
      </div>
      <div className="contact item center">
        <Logo />
      </div>
      <div className="contact item side right">
        <h6>
          <Email />
          krnant@icloud.com
        </h6>
        <h6>
          <Phone />
          +375201830403
        </h6>
      </div>
    </div>
  );
};
