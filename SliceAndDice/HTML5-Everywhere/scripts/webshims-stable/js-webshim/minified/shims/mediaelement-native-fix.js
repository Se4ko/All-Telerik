jQuery.webshims.register("mediaelement-native-fix",function(e,t,i,n){if(!Modernizr.videoBuffered){var a=function(e){var i=t.data(e,"mediaelementBuffered");return i||(i={buffered:{start:function(e){return e>=i.buffered.length?(t.error("buffered index size error"),undefined):0},end:function(e){return e>=i.buffered.length?(t.error("buffered index size error"),undefined):i.loaded},length:0},loaded:0},t.data(e,"mediaelementBuffered",i)),i},r=function(i){if(i=i.originalEvent,i&&"lengthComputable"in i){var n=t.data(i.target,"mediaelement");if((!n||"html5"==n.isActive)&&i.lengthComputable&&"loaded"in i){var r=i.target.duration,o=a(i.target);o.loaded=r?i.loaded/i.total*r:0,o.loaded&&(o.buffered.length=1),"load"==i.type&&e(i.target).triggerHandler("progress")}}},o=function(e){var t=a(e.target);t.buffered.length=0,t.loaded=0};["audio","video"].forEach(function(e){var i=t.defineNodeNameProperty(e,"buffered",{prop:{get:function(){var e=t.data(this,"mediaelement");return e&&"flash"==e.isActive&&i.prop._supget?(i.prop._supget.apply(this),undefined):a(this).buffered}}})}),function(){var e=n.createElement("video");if(!("preload"in e)&&"autobuffer"in e){var i={metadata:1,none:1};t.onNodeNamesPropertyModify(["audio","video"],["preload"],{set:function(e,n,a){i[e]||"removeAttr"==a?this.autobuffer=!1:"html5"==!(t.data(this,"mediaelement")||{}).isActive&&(this.autobuffer=!0)},initAttr:!0})}}(),t.addReady(function(t,i){e("video, audio",t).add(i.filter("video, audio")).on("load progress",r).on("emptied",o)})}});