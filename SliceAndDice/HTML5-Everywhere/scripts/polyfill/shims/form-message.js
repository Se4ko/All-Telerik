jQuery.webshims.register("form-message",function(e,t,i,n,a,r){"use strict";var o=t.validityMessages,s=r.overrideMessages||r.customMessages?["customValidationMessage"]:[];o.en=e.extend(!0,{typeMismatch:{defaultMessage:"Please enter a valid value.",email:"Please enter an email address.",url:"Please enter a URL.",number:"Please enter a number.",date:"Please enter a date.",time:"Please enter a time.",range:"Invalid input.",month:"Please enter a valid value.","datetime-local":"Please enter a datetime."},rangeUnderflow:{defaultMessage:"Value must be greater than or equal to {%min}."},rangeOverflow:{defaultMessage:"Value must be less than or equal to {%max}."},stepMismatch:"Invalid input.",tooLong:"Please enter at most {%maxlength} character(s). You entered {%valueLen}.",patternMismatch:"Invalid input. {%title}",valueMissing:{defaultMessage:"Please fill out this field.",checkbox:"Please check this box if you want to proceed."}},o.en||o["en-US"]||{}),"object"==typeof o.en.valueMissing&&["select","radio"].forEach(function(e){o.en.valueMissing[e]="Please select an option."}),"object"==typeof o.en.rangeUnderflow&&["date","time","datetime-local","month"].forEach(function(e){o.en.rangeUnderflow[e]="Value must be at or after {%min}."}),"object"==typeof o.en.rangeOverflow&&["date","time","datetime-local","month"].forEach(function(e){o.en.rangeOverflow[e]="Value must be at or before {%max}."}),o["en-US"]=o["en-US"]||o.en,o[""]=o[""]||o["en-US"],o.de=e.extend(!0,{typeMismatch:{defaultMessage:"{%value} ist in diesem Feld nicht zulässig.",email:"{%value} ist keine gültige E-Mail-Adresse.",url:"{%value} ist kein(e) gültige(r) Webadresse/Pfad.",number:"{%value} ist keine Nummer.",date:"{%value} ist kein Datum.",time:"{%value} ist keine Uhrzeit.",month:"{%value} ist in diesem Feld nicht zulässig.",range:"{%value} ist keine Nummer.","datetime-local":"{%value} ist kein Datum-Uhrzeit Format."},rangeUnderflow:{defaultMessage:"{%value} ist zu niedrig. {%min} ist der unterste Wert, den Sie benutzen können."},rangeOverflow:{defaultMessage:"{%value} ist zu hoch. {%max} ist der oberste Wert, den Sie benutzen können."},stepMismatch:"Der Wert {%value} ist in diesem Feld nicht zulässig. Hier sind nur bestimmte Werte zulässig. {%title}",tooLong:"Der eingegebene Text ist zu lang! Sie haben {%valueLen} Zeichen eingegeben, dabei sind {%maxlength} das Maximum.",patternMismatch:"{%value} hat für dieses Eingabefeld ein falsches Format. {%title}",valueMissing:{defaultMessage:"Bitte geben Sie einen Wert ein.",checkbox:"Bitte aktivieren Sie das Kästchen."}},o.de||{}),"object"==typeof o.de.valueMissing&&["select","radio"].forEach(function(e){o.de.valueMissing[e]="Bitte wählen Sie eine Option aus."}),"object"==typeof o.de.rangeUnderflow&&["date","time","datetime-local","month"].forEach(function(e){o.de.rangeUnderflow[e]="{%value} ist zu früh. {%min} ist die früheste Zeit, die Sie benutzen können."}),"object"==typeof o.de.rangeOverflow&&["date","time","datetime-local","month"].forEach(function(e){o.de.rangeOverflow[e]="{%value} ist zu spät. {%max} ist die späteste Zeit, die Sie benutzen können."});var u=o[""],l=function(t,i){return t&&"string"!=typeof t&&(t=t[e.prop(i,"type")]||t[(i.nodeName||"").toLowerCase()]||t.defaultMessage),t||""},p={value:1,min:1,max:1};t.createValidationMessage=function(i,n){var a,r=l(u[n],i);return r||(r=l(o[""][n],i)||"invalid value",t.info("could not find errormessage for: "+n+" / "+e.prop(i,"type")+". in language: "+e.webshims.activeLang())),r&&["value","min","max","title","maxlength","label"].forEach(function(o){if(-1!==r.indexOf("{%"+o)){var s=("label"==o?e.trim(e('label[for="'+i.id+'"]',i.form).text()).replace(/\*$|:$/,""):e.prop(i,o))||"";"patternMismatch"!=n||"title"!=o||s||t.error("no title for patternMismatch provided. Always add a title attribute."),p[o]&&(a||(a=e(i).getShadowElement().data("wsspinner")),a&&a.formatValue&&(s=a.formatValue(s,!1))),r=r.replace("{%"+o+"}",s),"value"==o&&(r=r.replace("{%valueLen}",s.length))}}),r||""},(t.bugs.validationMessage||!Modernizr.formvalidation||t.bugs.bustedValidity)&&s.push("validationMessage"),t.activeLang({langObj:o,module:"form-core",callback:function(e){u=e}}),s.forEach(function(i){t.defineNodeNamesProperty(["fieldset","output","button"],i,{prop:{value:"",writeable:!1}}),["input","select","textarea"].forEach(function(n){var r=t.defineNodeNameProperty(n,i,{prop:{get:function(){var i=this,n="";if(!e.prop(i,"willValidate"))return n;var o=e.prop(i,"validity")||{valid:1};return o.valid?n:(n=t.getContentValidationMessage(i,o))?n:o.customError&&i.nodeName&&(n=Modernizr.formvalidation&&!t.bugs.bustedValidity&&r.prop._supget?r.prop._supget.call(i):t.data(i,"customvalidationMessage"))?n:(e.each(o,function(e,r){return"valid"!=e&&r?(n=t.createValidationMessage(i,e),n?!1:a):a}),n||"")},writeable:!1}})})})});