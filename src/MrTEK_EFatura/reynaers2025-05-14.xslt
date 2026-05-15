<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
  xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
  xmlns:ccts="urn:un:unece:uncefact:documentation:2"
  xmlns:clm54217="urn:un:unece:uncefact:codelist:specification:54217:2001"
  xmlns:clm5639="urn:un:unece:uncefact:codelist:specification:5639:1988"
  xmlns:clm66411="urn:un:unece:uncefact:codelist:specification:66411:2001"
  xmlns:clmIANAMIMEMediaType="urn:un:unece:uncefact:codelist:specification:IANAMIMEMediaType:2003"
  xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:link="http://www.xbrl.org/2003/linkbase"
  xmlns:n1="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
  xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
  xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
  xmlns:xbrldi="http://xbrl.org/2006/xbrldi" xmlns:xbrli="http://www.xbrl.org/2003/instance"
  xmlns:xdt="http://www.w3.org/2005/xpath-datatypes" xmlns:xlink="http://www.w3.org/1999/xlink"
  xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xsd="http://www.w3.org/2001/XMLSchema"
  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  exclude-result-prefixes="cac cbc ccts clm54217 clm5639 clm66411 clmIANAMIMEMediaType fn link n1 qdt udt xbrldi xbrli xdt xlink xs xsd xsi">
  <xsl:character-map name="a">
    <xsl:output-character character="&#133;" string=""/>
    <xsl:output-character character="&#158;" string=""/>
  </xsl:character-map>
  <xsl:decimal-format name="european" decimal-separator="," grouping-separator="." NaN=""/>
  <xsl:output version="4.0" method="html" indent="no" encoding="UTF-8"
    doctype-public="-//W3C//DTD HTML 4.01 Transitional//EN"
    doctype-system="http://www.w3.org/TR/html4/loose.dtd" use-character-maps="a"/>
    <xsl:param name="SV_OutputFormat" select="'HTML'"/>
    <xsl:variable name="XML" select="/"/>

    <xsl:template match="/">
      <html>
        <head>
          <title/>
			<script type="text/javascript">
				<![CDATA[var QRCode;!function(){function a(a){this.mode=c.MODE_8BIT_BYTE,this.data=a,this.parsedData=[];for(var b=[],d=0,e=this.data.length;e>d;d++){var f=this.data.charCodeAt(d);f>65536?(b[0]=240|(1835008&f)>>>18,b[1]=128|(258048&f)>>>12,b[2]=128|(4032&f)>>>6,b[3]=128|63&f):f>2048?(b[0]=224|(61440&f)>>>12,b[1]=128|(4032&f)>>>6,b[2]=128|63&f):f>128?(b[0]=192|(1984&f)>>>6,b[1]=128|63&f):b[0]=f,this.parsedData=this.parsedData.concat(b)}this.parsedData.length!=this.data.length&&(this.parsedData.unshift(191),this.parsedData.unshift(187),this.parsedData.unshift(239))}function b(a,b){this.typeNumber=a,this.errorCorrectLevel=b,this.modules=null,this.moduleCount=0,this.dataCache=null,this.dataList=[]}function i(a,b){if(void 0==a.length)throw new Error(a.length+"/"+b);for(var c=0;c<a.length&&0==a[c];)c++;this.num=new Array(a.length-c+b);for(var d=0;d<a.length-c;d++)this.num[d]=a[d+c]}function j(a,b){this.totalCount=a,this.dataCount=b}function k(){this.buffer=[],this.length=0}function m(){return"undefined"!=typeof CanvasRenderingContext2D}function n(){var a=!1,b=navigator.userAgent;return/android/i.test(b)&&(a=!0,aMat=b.toString().match(/android ([0-9]\.[0-9])/i),aMat&&aMat[1]&&(a=parseFloat(aMat[1]))),a}function r(a,b){for(var c=1,e=s(a),f=0,g=l.length;g>=f;f++){var h=0;switch(b){case d.L:h=l[f][0];break;case d.M:h=l[f][1];break;case d.Q:h=l[f][2];break;case d.H:h=l[f][3]}if(h>=e)break;c++}if(c>l.length)throw new Error("Too long data");return c}function s(a){var b=encodeURI(a).toString().replace(/\%[0-9a-fA-F]{2}/g,"a");return b.length+(b.length!=a?3:0)}a.prototype={getLength:function(){return this.parsedData.length},write:function(a){for(var b=0,c=this.parsedData.length;c>b;b++)a.put(this.parsedData[b],8)}},b.prototype={addData:function(b){var c=new a(b);this.dataList.push(c),this.dataCache=null},isDark:function(a,b){if(0>a||this.moduleCount<=a||0>b||this.moduleCount<=b)throw new Error(a+","+b);return this.modules[a][b]},getModuleCount:function(){return this.moduleCount},make:function(){this.makeImpl(!1,this.getBestMaskPattern())},makeImpl:function(a,c){this.moduleCount=4*this.typeNumber+17,this.modules=new Array(this.moduleCount);for(var d=0;d<this.moduleCount;d++){this.modules[d]=new Array(this.moduleCount);for(var e=0;e<this.moduleCount;e++)this.modules[d][e]=null}this.setupPositionProbePattern(0,0),this.setupPositionProbePattern(this.moduleCount-7,0),this.setupPositionProbePattern(0,this.moduleCount-7),this.setupPositionAdjustPattern(),this.setupTimingPattern(),this.setupTypeInfo(a,c),this.typeNumber>=7&&this.setupTypeNumber(a),null==this.dataCache&&(this.dataCache=b.createData(this.typeNumber,this.errorCorrectLevel,this.dataList)),this.mapData(this.dataCache,c)},setupPositionProbePattern:function(a,b){for(var c=-1;7>=c;c++)if(!(-1>=a+c||this.moduleCount<=a+c))for(var d=-1;7>=d;d++)-1>=b+d||this.moduleCount<=b+d||(this.modules[a+c][b+d]=c>=0&&6>=c&&(0==d||6==d)||d>=0&&6>=d&&(0==c||6==c)||c>=2&&4>=c&&d>=2&&4>=d?!0:!1)},getBestMaskPattern:function(){for(var a=0,b=0,c=0;8>c;c++){this.makeImpl(!0,c);var d=f.getLostPoint(this);(0==c||a>d)&&(a=d,b=c)}return b},createMovieClip:function(a,b,c){var d=a.createEmptyMovieClip(b,c),e=1;this.make();for(var f=0;f<this.modules.length;f++)for(var g=f*e,h=0;h<this.modules[f].length;h++){var i=h*e,j=this.modules[f][h];j&&(d.beginFill(0,100),d.moveTo(i,g),d.lineTo(i+e,g),d.lineTo(i+e,g+e),d.lineTo(i,g+e),d.endFill())}return d},setupTimingPattern:function(){for(var a=8;a<this.moduleCount-8;a++)null==this.modules[a][6]&&(this.modules[a][6]=0==a%2);for(var b=8;b<this.moduleCount-8;b++)null==this.modules[6][b]&&(this.modules[6][b]=0==b%2)},setupPositionAdjustPattern:function(){for(var a=f.getPatternPosition(this.typeNumber),b=0;b<a.length;b++)for(var c=0;c<a.length;c++){var d=a[b],e=a[c];if(null==this.modules[d][e])for(var g=-2;2>=g;g++)for(var h=-2;2>=h;h++)this.modules[d+g][e+h]=-2==g||2==g||-2==h||2==h||0==g&&0==h?!0:!1}},setupTypeNumber:function(a){for(var b=f.getBCHTypeNumber(this.typeNumber),c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[Math.floor(c/3)][c%3+this.moduleCount-8-3]=d}for(var c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[c%3+this.moduleCount-8-3][Math.floor(c/3)]=d}},setupTypeInfo:function(a,b){for(var c=this.errorCorrectLevel<<3|b,d=f.getBCHTypeInfo(c),e=0;15>e;e++){var g=!a&&1==(1&d>>e);6>e?this.modules[e][8]=g:8>e?this.modules[e+1][8]=g:this.modules[this.moduleCount-15+e][8]=g}for(var e=0;15>e;e++){var g=!a&&1==(1&d>>e);8>e?this.modules[8][this.moduleCount-e-1]=g:9>e?this.modules[8][15-e-1+1]=g:this.modules[8][15-e-1]=g}this.modules[this.moduleCount-8][8]=!a},mapData:function(a,b){for(var c=-1,d=this.moduleCount-1,e=7,g=0,h=this.moduleCount-1;h>0;h-=2)for(6==h&&h--;;){for(var i=0;2>i;i++)if(null==this.modules[d][h-i]){var j=!1;g<a.length&&(j=1==(1&a[g]>>>e));var k=f.getMask(b,d,h-i);k&&(j=!j),this.modules[d][h-i]=j,e--,-1==e&&(g++,e=7)}if(d+=c,0>d||this.moduleCount<=d){d-=c,c=-c;break}}}},b.PAD0=236,b.PAD1=17,b.createData=function(a,c,d){for(var e=j.getRSBlocks(a,c),g=new k,h=0;h<d.length;h++){var i=d[h];g.put(i.mode,4),g.put(i.getLength(),f.getLengthInBits(i.mode,a)),i.write(g)}for(var l=0,h=0;h<e.length;h++)l+=e[h].dataCount;if(g.getLengthInBits()>8*l)throw new Error("code length overflow. ("+g.getLengthInBits()+">"+8*l+")");for(g.getLengthInBits()+4<=8*l&&g.put(0,4);0!=g.getLengthInBits()%8;)g.putBit(!1);for(;;){if(g.getLengthInBits()>=8*l)break;if(g.put(b.PAD0,8),g.getLengthInBits()>=8*l)break;g.put(b.PAD1,8)}return b.createBytes(g,e)},b.createBytes=function(a,b){for(var c=0,d=0,e=0,g=new Array(b.length),h=new Array(b.length),j=0;j<b.length;j++){var k=b[j].dataCount,l=b[j].totalCount-k;d=Math.max(d,k),e=Math.max(e,l),g[j]=new Array(k);for(var m=0;m<g[j].length;m++)g[j][m]=255&a.buffer[m+c];c+=k;var n=f.getErrorCorrectPolynomial(l),o=new i(g[j],n.getLength()-1),p=o.mod(n);h[j]=new Array(n.getLength()-1);for(var m=0;m<h[j].length;m++){var q=m+p.getLength()-h[j].length;h[j][m]=q>=0?p.get(q):0}}for(var r=0,m=0;m<b.length;m++)r+=b[m].totalCount;for(var s=new Array(r),t=0,m=0;d>m;m++)for(var j=0;j<b.length;j++)m<g[j].length&&(s[t++]=g[j][m]);for(var m=0;e>m;m++)for(var j=0;j<b.length;j++)m<h[j].length&&(s[t++]=h[j][m]);return s};for(var c={MODE_NUMBER:1,MODE_ALPHA_NUM:2,MODE_8BIT_BYTE:4,MODE_KANJI:8},d={L:1,M:0,Q:3,H:2},e={PATTERN000:0,PATTERN001:1,PATTERN010:2,PATTERN011:3,PATTERN100:4,PATTERN101:5,PATTERN110:6,PATTERN111:7},f={PATTERN_POSITION_TABLE:[[],[6,18],[6,22],[6,26],[6,30],[6,34],[6,22,38],[6,24,42],[6,26,46],[6,28,50],[6,30,54],[6,32,58],[6,34,62],[6,26,46,66],[6,26,48,70],[6,26,50,74],[6,30,54,78],[6,30,56,82],[6,30,58,86],[6,34,62,90],[6,28,50,72,94],[6,26,50,74,98],[6,30,54,78,102],[6,28,54,80,106],[6,32,58,84,110],[6,30,58,86,114],[6,34,62,90,118],[6,26,50,74,98,122],[6,30,54,78,102,126],[6,26,52,78,104,130],[6,30,56,82,108,134],[6,34,60,86,112,138],[6,30,58,86,114,142],[6,34,62,90,118,146],[6,30,54,78,102,126,150],[6,24,50,76,102,128,154],[6,28,54,80,106,132,158],[6,32,58,84,110,136,162],[6,26,54,82,110,138,166],[6,30,58,86,114,142,170]],G15:1335,G18:7973,G15_MASK:21522,getBCHTypeInfo:function(a){for(var b=a<<10;f.getBCHDigit(b)-f.getBCHDigit(f.G15)>=0;)b^=f.G15<<f.getBCHDigit(b)-f.getBCHDigit(f.G15);return(a<<10|b)^f.G15_MASK},getBCHTypeNumber:function(a){for(var b=a<<12;f.getBCHDigit(b)-f.getBCHDigit(f.G18)>=0;)b^=f.G18<<f.getBCHDigit(b)-f.getBCHDigit(f.G18);return a<<12|b},getBCHDigit:function(a){for(var b=0;0!=a;)b++,a>>>=1;return b},getPatternPosition:function(a){return f.PATTERN_POSITION_TABLE[a-1]},getMask:function(a,b,c){switch(a){case e.PATTERN000:return 0==(b+c)%2;case e.PATTERN001:return 0==b%2;case e.PATTERN010:return 0==c%3;case e.PATTERN011:return 0==(b+c)%3;case e.PATTERN100:return 0==(Math.floor(b/2)+Math.floor(c/3))%2;case e.PATTERN101:return 0==b*c%2+b*c%3;case e.PATTERN110:return 0==(b*c%2+b*c%3)%2;case e.PATTERN111:return 0==(b*c%3+(b+c)%2)%2;default:throw new Error("bad maskPattern:"+a)}},getErrorCorrectPolynomial:function(a){for(var b=new i([1],0),c=0;a>c;c++)b=b.multiply(new i([1,g.gexp(c)],0));return b},getLengthInBits:function(a,b){if(b>=1&&10>b)switch(a){case c.MODE_NUMBER:return 10;case c.MODE_ALPHA_NUM:return 9;case c.MODE_8BIT_BYTE:return 8;case c.MODE_KANJI:return 8;default:throw new Error("mode:"+a)}else if(27>b)switch(a){case c.MODE_NUMBER:return 12;case c.MODE_ALPHA_NUM:return 11;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 10;default:throw new Error("mode:"+a)}else{if(!(41>b))throw new Error("type:"+b);switch(a){case c.MODE_NUMBER:return 14;case c.MODE_ALPHA_NUM:return 13;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 12;default:throw new Error("mode:"+a)}}},getLostPoint:function(a){for(var b=a.getModuleCount(),c=0,d=0;b>d;d++)for(var e=0;b>e;e++){for(var f=0,g=a.isDark(d,e),h=-1;1>=h;h++)if(!(0>d+h||d+h>=b))for(var i=-1;1>=i;i++)0>e+i||e+i>=b||(0!=h||0!=i)&&g==a.isDark(d+h,e+i)&&f++;f>5&&(c+=3+f-5)}for(var d=0;b-1>d;d++)for(var e=0;b-1>e;e++){var j=0;a.isDark(d,e)&&j++,a.isDark(d+1,e)&&j++,a.isDark(d,e+1)&&j++,a.isDark(d+1,e+1)&&j++,(0==j||4==j)&&(c+=3)}for(var d=0;b>d;d++)for(var e=0;b-6>e;e++)a.isDark(d,e)&&!a.isDark(d,e+1)&&a.isDark(d,e+2)&&a.isDark(d,e+3)&&a.isDark(d,e+4)&&!a.isDark(d,e+5)&&a.isDark(d,e+6)&&(c+=40);for(var e=0;b>e;e++)for(var d=0;b-6>d;d++)a.isDark(d,e)&&!a.isDark(d+1,e)&&a.isDark(d+2,e)&&a.isDark(d+3,e)&&a.isDark(d+4,e)&&!a.isDark(d+5,e)&&a.isDark(d+6,e)&&(c+=40);for(var k=0,e=0;b>e;e++)for(var d=0;b>d;d++)a.isDark(d,e)&&k++;var l=Math.abs(100*k/b/b-50)/5;return c+=10*l}},g={glog:function(a){if(1>a)throw new Error("glog("+a+")");return g.LOG_TABLE[a]},gexp:function(a){for(;0>a;)a+=255;for(;a>=256;)a-=255;return g.EXP_TABLE[a]},EXP_TABLE:new Array(256),LOG_TABLE:new Array(256)},h=0;8>h;h++)g.EXP_TABLE[h]=1<<h;for(var h=8;256>h;h++)g.EXP_TABLE[h]=g.EXP_TABLE[h-4]^g.EXP_TABLE[h-5]^g.EXP_TABLE[h-6]^g.EXP_TABLE[h-8];for(var h=0;255>h;h++)g.LOG_TABLE[g.EXP_TABLE[h]]=h;i.prototype={get:function(a){return this.num[a]},getLength:function(){return this.num.length},multiply:function(a){for(var b=new Array(this.getLength()+a.getLength()-1),c=0;c<this.getLength();c++)for(var d=0;d<a.getLength();d++)b[c+d]^=g.gexp(g.glog(this.get(c))+g.glog(a.get(d)));return new i(b,0)},mod:function(a){if(this.getLength()-a.getLength()<0)return this;for(var b=g.glog(this.get(0))-g.glog(a.get(0)),c=new Array(this.getLength()),d=0;d<this.getLength();d++)c[d]=this.get(d);for(var d=0;d<a.getLength();d++)c[d]^=g.gexp(g.glog(a.get(d))+b);return new i(c,0).mod(a)}},j.RS_BLOCK_TABLE=[[1,26,19],[1,26,16],[1,26,13],[1,26,9],[1,44,34],[1,44,28],[1,44,22],[1,44,16],[1,70,55],[1,70,44],[2,35,17],[2,35,13],[1,100,80],[2,50,32],[2,50,24],[4,25,9],[1,134,108],[2,67,43],[2,33,15,2,34,16],[2,33,11,2,34,12],[2,86,68],[4,43,27],[4,43,19],[4,43,15],[2,98,78],[4,49,31],[2,32,14,4,33,15],[4,39,13,1,40,14],[2,121,97],[2,60,38,2,61,39],[4,40,18,2,41,19],[4,40,14,2,41,15],[2,146,116],[3,58,36,2,59,37],[4,36,16,4,37,17],[4,36,12,4,37,13],[2,86,68,2,87,69],[4,69,43,1,70,44],[6,43,19,2,44,20],[6,43,15,2,44,16],[4,101,81],[1,80,50,4,81,51],[4,50,22,4,51,23],[3,36,12,8,37,13],[2,116,92,2,117,93],[6,58,36,2,59,37],[4,46,20,6,47,21],[7,42,14,4,43,15],[4,133,107],[8,59,37,1,60,38],[8,44,20,4,45,21],[12,33,11,4,34,12],[3,145,115,1,146,116],[4,64,40,5,65,41],[11,36,16,5,37,17],[11,36,12,5,37,13],[5,109,87,1,110,88],[5,65,41,5,66,42],[5,54,24,7,55,25],[11,36,12],[5,122,98,1,123,99],[7,73,45,3,74,46],[15,43,19,2,44,20],[3,45,15,13,46,16],[1,135,107,5,136,108],[10,74,46,1,75,47],[1,50,22,15,51,23],[2,42,14,17,43,15],[5,150,120,1,151,121],[9,69,43,4,70,44],[17,50,22,1,51,23],[2,42,14,19,43,15],[3,141,113,4,142,114],[3,70,44,11,71,45],[17,47,21,4,48,22],[9,39,13,16,40,14],[3,135,107,5,136,108],[3,67,41,13,68,42],[15,54,24,5,55,25],[15,43,15,10,44,16],[4,144,116,4,145,117],[17,68,42],[17,50,22,6,51,23],[19,46,16,6,47,17],[2,139,111,7,140,112],[17,74,46],[7,54,24,16,55,25],[34,37,13],[4,151,121,5,152,122],[4,75,47,14,76,48],[11,54,24,14,55,25],[16,45,15,14,46,16],[6,147,117,4,148,118],[6,73,45,14,74,46],[11,54,24,16,55,25],[30,46,16,2,47,17],[8,132,106,4,133,107],[8,75,47,13,76,48],[7,54,24,22,55,25],[22,45,15,13,46,16],[10,142,114,2,143,115],[19,74,46,4,75,47],[28,50,22,6,51,23],[33,46,16,4,47,17],[8,152,122,4,153,123],[22,73,45,3,74,46],[8,53,23,26,54,24],[12,45,15,28,46,16],[3,147,117,10,148,118],[3,73,45,23,74,46],[4,54,24,31,55,25],[11,45,15,31,46,16],[7,146,116,7,147,117],[21,73,45,7,74,46],[1,53,23,37,54,24],[19,45,15,26,46,16],[5,145,115,10,146,116],[19,75,47,10,76,48],[15,54,24,25,55,25],[23,45,15,25,46,16],[13,145,115,3,146,116],[2,74,46,29,75,47],[42,54,24,1,55,25],[23,45,15,28,46,16],[17,145,115],[10,74,46,23,75,47],[10,54,24,35,55,25],[19,45,15,35,46,16],[17,145,115,1,146,116],[14,74,46,21,75,47],[29,54,24,19,55,25],[11,45,15,46,46,16],[13,145,115,6,146,116],[14,74,46,23,75,47],[44,54,24,7,55,25],[59,46,16,1,47,17],[12,151,121,7,152,122],[12,75,47,26,76,48],[39,54,24,14,55,25],[22,45,15,41,46,16],[6,151,121,14,152,122],[6,75,47,34,76,48],[46,54,24,10,55,25],[2,45,15,64,46,16],[17,152,122,4,153,123],[29,74,46,14,75,47],[49,54,24,10,55,25],[24,45,15,46,46,16],[4,152,122,18,153,123],[13,74,46,32,75,47],[48,54,24,14,55,25],[42,45,15,32,46,16],[20,147,117,4,148,118],[40,75,47,7,76,48],[43,54,24,22,55,25],[10,45,15,67,46,16],[19,148,118,6,149,119],[18,75,47,31,76,48],[34,54,24,34,55,25],[20,45,15,61,46,16]],j.getRSBlocks=function(a,b){var c=j.getRsBlockTable(a,b);if(void 0==c)throw new Error("bad rs block @ typeNumber:"+a+"/errorCorrectLevel:"+b);for(var d=c.length/3,e=[],f=0;d>f;f++)for(var g=c[3*f+0],h=c[3*f+1],i=c[3*f+2],k=0;g>k;k++)e.push(new j(h,i));return e},j.getRsBlockTable=function(a,b){switch(b){case d.L:return j.RS_BLOCK_TABLE[4*(a-1)+0];case d.M:return j.RS_BLOCK_TABLE[4*(a-1)+1];case d.Q:return j.RS_BLOCK_TABLE[4*(a-1)+2];case d.H:return j.RS_BLOCK_TABLE[4*(a-1)+3];default:return void 0}},k.prototype={get:function(a){var b=Math.floor(a/8);return 1==(1&this.buffer[b]>>>7-a%8)},put:function(a,b){for(var c=0;b>c;c++)this.putBit(1==(1&a>>>b-c-1))},getLengthInBits:function(){return this.length},putBit:function(a){var b=Math.floor(this.length/8);this.buffer.length<=b&&this.buffer.push(0),a&&(this.buffer[b]|=128>>>this.length%8),this.length++}};var l=[[17,14,11,7],[32,26,20,14],[53,42,32,24],[78,62,46,34],[106,84,60,44],[134,106,74,58],[154,122,86,64],[192,152,108,84],[230,180,130,98],[271,213,151,119],[321,251,177,137],[367,287,203,155],[425,331,241,177],[458,362,258,194],[520,412,292,220],[586,450,322,250],[644,504,364,280],[718,560,394,310],[792,624,442,338],[858,666,482,382],[929,711,509,403],[1003,779,565,439],[1091,857,611,461],[1171,911,661,511],[1273,997,715,535],[1367,1059,751,593],[1465,1125,805,625],[1528,1190,868,658],[1628,1264,908,698],[1732,1370,982,742],[1840,1452,1030,790],[1952,1538,1112,842],[2068,1628,1168,898],[2188,1722,1228,958],[2303,1809,1283,983],[2431,1911,1351,1051],[2563,1989,1423,1093],[2699,2099,1499,1139],[2809,2213,1579,1219],[2953,2331,1663,1273]],o=function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){function g(a,b){var c=document.createElementNS("http://www.w3.org/2000/svg",a);for(var d in b)b.hasOwnProperty(d)&&c.setAttribute(d,b[d]);return c}var b=this._htOption,c=this._el,d=a.getModuleCount();Math.floor(b.width/d),Math.floor(b.height/d),this.clear();var h=g("svg",{viewBox:"0 0 "+String(d)+" "+String(d),width:"100%",height:"100%",fill:b.colorLight});h.setAttributeNS("http://www.w3.org/2000/xmlns/","xmlns:xlink","http://www.w3.org/1999/xlink"),c.appendChild(h),h.appendChild(g("rect",{fill:b.colorDark,width:"1",height:"1",id:"template"}));for(var i=0;d>i;i++)for(var j=0;d>j;j++)if(a.isDark(i,j)){var k=g("use",{x:String(i),y:String(j)});k.setAttributeNS("http://www.w3.org/1999/xlink","href","#template"),h.appendChild(k)}},a.prototype.clear=function(){for(;this._el.hasChildNodes();)this._el.removeChild(this._el.lastChild)},a}(),p="svg"===document.documentElement.tagName.toLowerCase(),q=p?o:m()?function(){function a(){this._elImage.src=this._elCanvas.toDataURL("image/png"),this._elImage.style.display="block",this._elCanvas.style.display="none"}function d(a,b){var c=this;if(c._fFail=b,c._fSuccess=a,null===c._bSupportDataURI){var d=document.createElement("img"),e=function(){c._bSupportDataURI=!1,c._fFail&&_fFail.call(c)},f=function(){c._bSupportDataURI=!0,c._fSuccess&&c._fSuccess.call(c)};return d.onabort=e,d.onerror=e,d.onload=f,d.src="data:image/gif;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAHElEQVQI12P4//8/w38GIAXDIBKE0DHxgljNBAAO9TXL0Y4OHwAAAABJRU5ErkJggg==",void 0}c._bSupportDataURI===!0&&c._fSuccess?c._fSuccess.call(c):c._bSupportDataURI===!1&&c._fFail&&c._fFail.call(c)}if(this._android&&this._android<=2.1){var b=1/window.devicePixelRatio,c=CanvasRenderingContext2D.prototype.drawImage;CanvasRenderingContext2D.prototype.drawImage=function(a,d,e,f,g,h,i,j){if("nodeName"in a&&/img/i.test(a.nodeName))for(var l=arguments.length-1;l>=1;l--)arguments[l]=arguments[l]*b;else"undefined"==typeof j&&(arguments[1]*=b,arguments[2]*=b,arguments[3]*=b,arguments[4]*=b);c.apply(this,arguments)}}var e=function(a,b){this._bIsPainted=!1,this._android=n(),this._htOption=b,this._elCanvas=document.createElement("canvas"),this._elCanvas.width=b.width,this._elCanvas.height=b.height,a.appendChild(this._elCanvas),this._el=a,this._oContext=this._elCanvas.getContext("2d"),this._bIsPainted=!1,this._elImage=document.createElement("img"),this._elImage.style.display="none",this._el.appendChild(this._elImage),this._bSupportDataURI=null};return e.prototype.draw=function(a){var b=this._elImage,c=this._oContext,d=this._htOption,e=a.getModuleCount(),f=d.width/e,g=d.height/e,h=Math.round(f),i=Math.round(g);b.style.display="none",this.clear();for(var j=0;e>j;j++)for(var k=0;e>k;k++){var l=a.isDark(j,k),m=k*f,n=j*g;c.strokeStyle=l?d.colorDark:d.colorLight,c.lineWidth=1,c.fillStyle=l?d.colorDark:d.colorLight,c.fillRect(m,n,f,g),c.strokeRect(Math.floor(m)+.5,Math.floor(n)+.5,h,i),c.strokeRect(Math.ceil(m)-.5,Math.ceil(n)-.5,h,i)}this._bIsPainted=!0},e.prototype.makeImage=function(){this._bIsPainted&&d.call(this,a)},e.prototype.isPainted=function(){return this._bIsPainted},e.prototype.clear=function(){this._oContext.clearRect(0,0,this._elCanvas.width,this._elCanvas.height),this._bIsPainted=!1},e.prototype.round=function(a){return a?Math.floor(1e3*a)/1e3:a},e}():function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){for(var b=this._htOption,c=this._el,d=a.getModuleCount(),e=Math.floor(b.width/d),f=Math.floor(b.height/d),g=['<table style="border:0;border-collapse:collapse;">'],h=0;d>h;h++){g.push("<tr>");for(var i=0;d>i;i++)g.push('<td style="border:0;border-collapse:collapse;padding:0;margin:0;width:'+e+"px;height:"+f+"px;background-color:"+(a.isDark(h,i)?b.colorDark:b.colorLight)+';"></td>');g.push("</tr>")}g.push("</table>"),c.innerHTML=g.join("");var j=c.childNodes[0],k=(b.width-j.offsetWidth)/2,l=(b.height-j.offsetHeight)/2;k>0&&l>0&&(j.style.margin=l+"px "+k+"px")},a.prototype.clear=function(){this._el.innerHTML=""},a}();QRCode=function(a,b){if(this._htOption={width:256,height:256,typeNumber:4,colorDark:"#000000",colorLight:"#ffffff",correctLevel:d.H},"string"==typeof b&&(b={text:b}),b)for(var c in b)this._htOption[c]=b[c];"string"==typeof a&&(a=document.getElementById(a)),this._android=n(),this._el=a,this._oQRCode=null,this._oDrawing=new q(this._el,this._htOption),this._htOption.text&&this.makeCode(this._htOption.text)},QRCode.prototype.makeCode=function(a){this._oQRCode=new b(r(a,this._htOption.correctLevel),this._htOption.correctLevel),this._oQRCode.addData(a),this._oQRCode.make(),this._el.title=a,this._oDrawing.draw(this._oQRCode),this.makeImage()},QRCode.prototype.makeImage=function(){"function"==typeof this._oDrawing.makeImage&&(!this._android||this._android>=3)&&this._oDrawing.makeImage()},QRCode.prototype.clear=function(){this._oDrawing.clear()},QRCode.CorrectLevel=d}();]]>
			</script>
          <style type="text/css">
            body {
            background-color: #FFFFFF;
            font-family: 'Tahoma', "Times New Roman", Times, serif;
            font-size: 11px;
            color: #666666;
            }
            h1, h2 {
            padding-bottom: 3px;
            padding-top: 3px;
            margin-bottom: 5px;
            text-transform: uppercase;
            font-family: Arial, Helvetica, sans-serif;
            }
            h1 {
            font-size: 1.4em;
            text-transform:none;
            }
            h2 {
            font-size: 1em;
            color: brown;
            }
            h3 {
            font-size: 1em;
            color: #333333;
            text-align: justify;
            margin: 0;
            padding: 0;
            }
            h4 {
            font-size: 1.1em;
            font-style: bold;
            font-family: Arial, Helvetica, sans-serif;
            color: #000000;
            margin: 0;
            padding: 0;
            }
            hr {
            height:2px;
            color: #000000;
            background-color: #000000;
            border-bottom: 1px solid #000000;
            }
            p, ul, ol {
            margin-top: 1.5em;
            }
            ul, ol {
            margin-left: 3em;
            }
            blockquote {
            margin-left: 3em;
            margin-right: 3em;
            font-style: italic;
            }
            a {
            text-decoration: none;
            color: #70A300;
            }
            a:hover {
            border: none;
            color: #70A300;
            }
            #despatchTable {
            border-collapse:collapse;
            font-size:11px;
            float:right;
            border-color:gray;
            }
            #ettnTable {
            border-collapse:collapse;
            font-size:11px;
            border-color:gray;
            }
            #customerPartyTable {
            border-width: 0px;
            border-spacing:;
            border-style: inset;
            border-color: gray;
            border-collapse: collapse;
            background-color:
            }
            #customerIDTable {
            border-width: 2px;
            border-spacing:;
            border-style: inset;
            border-color: gray;
            border-collapse: collapse;
            background-color:
            }
            #customerIDTableTd {
            border-width: 2px;
            border-spacing:;
            border-style: inset;
            border-color: gray;
            border-collapse: collapse;
            background-color:
            }
            #lineTable {
            border-width:2px;
            border-spacing:;
            border-style: inset;
            border-color: black;
            border-collapse: collapse;
            background-color:;
            }
            #lineTableTd {
            border-width: 1px;
            padding: 1px;
            border-style: inset;
            border-color: black;
            background-color: white;
            }
            #lineTableTr {
            border-width: 1px;
            padding: 0px;
            border-style: inset;
            border-color: black;
            background-color: white;
            -moz-border-radius:;
            }
            #lineTableDummyTd {
            border-width: 1px;
            border-color:white;
            padding: 1px;
            border-style: inset;
            border-color: black;
            background-color: white;
            }
            #lineTableBudgetTd {
            border-width: 2px;
            border-spacing:0px;
            padding: 1px;
            border-style: inset;
            border-color: black;
            background-color: white;
            -moz-border-radius:;
            }
            #notesTable {
            border-width: 2px;
            border-spacing:;
            border-style: inset;
            border-color: black;
            border-collapse: collapse;
            background-color:
            }
            #notesTableTd {
            border-width: 0px;
            border-spacing:;
            border-style: inset;
            border-color: black;
            border-collapse: collapse;
            background-color:
            }
            table {
            border-spacing:0px;
            }
            #budgetContainerTable {
            border-width: 0px;
            border-spacing: 0px;
            border-style: inset;
            border-color: black;
            border-collapse: collapse;
            background-color:;
            }
            td {
            border-color:gray;
            }
          </style>
          <title>e-Fatura</title>
        </head>
        <body
          style="margin-left=0.6in; margin-right=0.6in; margin-top=0.79in; margin-bottom=0.79in">
          <xsl:for-each select="$XML">
            <table style="border-color:blue; " border="0" cellspacing="0px" width="800"
              cellpadding="0px">
              <tbody>
                <tr valign="top">
                  <td width="40%">
                    <br/>
                    <table align="center" border="0" width="100%">
                      <tbody>
                        <hr/>
                        <tr align="left">
                          <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party">
                            <td align="left">
                              <xsl:if test="cac:PartyName">
                                <xsl:value-of select="cac:PartyName/cbc:Name"/>
                                <br/>
                              </xsl:if>
                              <xsl:for-each select="cac:Person">
                                <xsl:for-each select="cbc:Title">
                                  <xsl:apply-templates/>
                                  <xsl:text>&#160;</xsl:text>
                                </xsl:for-each>
                                <xsl:for-each select="cbc:FirstName">
                                  <xsl:apply-templates/>
                                  <xsl:text>&#160;</xsl:text>
                                </xsl:for-each>
                                <xsl:for-each select="cbc:MiddleName">
                                  <xsl:apply-templates/>
                                  <xsl:text>&#160;</xsl:text>
                                </xsl:for-each>
                                <xsl:for-each select="cbc:FamilyName">
                                  <xsl:apply-templates/>
                                  <xsl:text>&#160;</xsl:text>
                                </xsl:for-each>
                                <xsl:for-each select="cbc:NameSuffix">
                                  <xsl:apply-templates/>
                                </xsl:for-each>
                              </xsl:for-each>
                            </td>
                          </xsl:for-each>
                        </tr>
                        <tr align="left">
                          <td align="left">
                          	Esentepe Mah. 23 Temmuz Sok. No:5/1 Şişli
                           <br/>
                           Istanbul TURKEY
                         </td>
                       </tr>
                       <xsl:if
                        test="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone or //n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telefax">
                        <tr align="left">
                          <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party">
                            <td align="left">
                              <xsl:for-each select="cac:Contact">
                                <xsl:if test="cbc:Telephone">
                                  <xsl:text>Tel: </xsl:text>
                                  <xsl:for-each select="cbc:Telephone">
                                    <xsl:apply-templates/>
                                  </xsl:for-each>
                                </xsl:if>
                                <xsl:if test="cbc:Telefax">
                                  <xsl:text> Fax: </xsl:text>
                                  <xsl:for-each select="cbc:Telefax">
                                    <xsl:apply-templates/>
                                  </xsl:for-each>
                                </xsl:if>
                                <xsl:text>&#160;</xsl:text>
                              </xsl:for-each>
                            </td>
                          </xsl:for-each>
                        </tr>
                      </xsl:if>
                      <xsl:for-each
                        select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cbc:WebsiteURI">
                        <tr align="left">
                          <td>
                            <xsl:text>Web Sitesi: </xsl:text>
                            <xsl:value-of select="."/>
                          </td>
                        </tr>
                      </xsl:for-each>
                      <xsl:for-each
                        select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                        <tr align="left">
                          <td>
                            <xsl:text>E-Posta: </xsl:text>
                            <xsl:value-of select="."/>
                          </td>
                        </tr>
                      </xsl:for-each>
                      <tr align="left">
                        <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party">
                          <td align="left">
                            <xsl:text>Vergi Dairesi: Zincirlikuyu</xsl:text>
                            
                          </td>
                        </xsl:for-each>
                      </tr>
                      <!--<xsl:for-each select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification">
                        <tr align="left">
                          <td>
                            <xsl:value-of select="cbc:ID/@schemeID"/>
                            <xsl:text>: </xsl:text>
                            <xsl:value-of select="cbc:ID"/>
                          </td>
                        </tr>
                      </xsl:for-each>-->
                      <tr align="left">
                        <td>
                          VKN: 735 061 8308
                        </td>
                      </tr>
                      <tr align="left">
                        <td>
                          İstanbul Ticaret Odası Sicil No: 638844
                        </td>
                      </tr>
                      <tr align="left">
                        <td>
                          Mersis no: 0-7350-6183-0800012
                        </td>
                      </tr>
                      <!--<tr align="left">
                        <td>
                            İnternet Adresi: www.reynaers.com.tr
                        </td>
                      </tr>-->
                    </tbody>
                  </table>
                  <!-- AGENT PARTY-->
                  <xsl:if test="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:AgentParty">
                    <table align="center" border="0" width="100%">
                      <tbody>
                        <hr/>
                        <tr align="left">
                          <xsl:for-each select="n1:Invoice">
                            <xsl:for-each select="cac:AccountingSupplierParty/cac:Party/cac:AgentParty">
                              <td align="left">
                                <xsl:if test="cac:PartyName">
                                  <xsl:value-of select="cac:PartyName/cbc:Name"/>
                                  <br/>
                                </xsl:if>
                                <xsl:for-each select="cac:Person">
                                  <xsl:for-each select="cbc:Title">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:FirstName">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:MiddleName">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:FamilyName">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:NameSuffix">
                                    <xsl:apply-templates/>
                                  </xsl:for-each>
                                </xsl:for-each>
                              </td>
                            </xsl:for-each>
                          </xsl:for-each>
                        </tr>
                        <tr align="left">
                          <xsl:for-each select="n1:Invoice">
                            <xsl:for-each select="cac:AccountingSupplierParty/cac:Party/cac:AgentParty">
                              <td align="left">
                                <xsl:for-each select="cac:PostalAddress">
                                  <xsl:for-each select="cbc:StreetName">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:BuildingName">
                                    <xsl:apply-templates/>
                                  </xsl:for-each>
                                  <xsl:if test="cbc:BuildingNumber">
                                    <span>
                                      <xsl:text> No:</xsl:text>
                                    </span>
                                    <xsl:for-each select="cbc:BuildingNumber">
                                      <xsl:apply-templates/>
                                    </xsl:for-each>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:if>
                                  <br/>
                                  <xsl:for-each select="cbc:PostalZone">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                  <xsl:for-each select="cbc:CitySubdivisionName">
                                    <xsl:apply-templates/>
                                  </xsl:for-each>
                                  <span>
                                    <xsl:text>/ </xsl:text>
                                  </span>
                                  <xsl:for-each select="cbc:CityName">
                                    <xsl:apply-templates/>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                </xsl:for-each>
                              </td>
                            </xsl:for-each>
                          </xsl:for-each>
                        </tr>
                        <xsl:if
                          test="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:AgentParty/cac:Contact/cbc:Telephone or //n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:AgentParty/cac:Contact/cbc:Telefax">
                          <tr align="left">
                            <xsl:for-each select="n1:Invoice">
                              <xsl:for-each select="cac:AccountingSupplierParty/cac:Party/cac:AgentParty">
                                <td align="left">
                                  <xsl:for-each select="cac:Contact">
                                    <xsl:if test="cbc:Telephone">
                                      <span>
                                        <xsl:text>Tel: </xsl:text>
                                      </span>
                                      <xsl:for-each select="cbc:Telephone">
                                        <xsl:apply-templates/>
                                      </xsl:for-each>
                                    </xsl:if>
                                    <xsl:if test="cbc:Telefax">
                                      <span>
                                        <xsl:text> Fax: </xsl:text>
                                      </span>
                                      <xsl:for-each select="cbc:Telefax">
                                        <xsl:apply-templates/>
                                      </xsl:for-each>
                                    </xsl:if>
                                    <span>
                                      <xsl:text>&#160;</xsl:text>
                                    </span>
                                  </xsl:for-each>
                                </td>
                              </xsl:for-each>
                            </xsl:for-each>
                          </tr>
                        </xsl:if>
                        <xsl:for-each
                          select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:AgentParty/cbc:WebsiteURI">
                          <tr align="left">
                            <td>
                              <xsl:text>Web Sitesi: </xsl:text>
                              <xsl:value-of select="."/>
                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:for-each
                          select="//n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:AgentParty/cac:Contact/cbc:ElectronicMail">
                          <tr align="left">
                            <td>
                              <xsl:text>E-Posta: </xsl:text>
                              <xsl:value-of select="."/>
                            </td>
                          </tr>
                        </xsl:for-each>
                      </tbody>
                    </table>
                  </xsl:if>
                  <hr/>
                </td>
                <td width="20%" align="center" valign="middle">
                  <br/>
                  <br/>
                  <img style="width:91px;" align="middle" alt="E-Fatura Logo"
                    src="data:image/jpeg;base64,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"/>

                    <h1 align="center">
                      <span style="font-weight:bold; ">

												<xsl:choose>
                          <xsl:when test="n1:Invoice/cbc:ProfileID='EARSIVFATURA'">
                           <xsl:text>e-Arşiv Fatura</xsl:text>
                          </xsl:when>
                          <xsl:otherwise>
                           <xsl:text>e-FATURA</xsl:text>
                          </xsl:otherwise>
                        </xsl:choose>
                        

                      </span>
                    </h1>
                  </td>
                                   <td width="20%" align="center" alt="Fatih Mensucat" valign="middle">
                    <img style="width:150px" src="data:image/jpeg;base64,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"/>
                  </td>
						<td width="20%" align="right" valign="middle">

									<div id="qrcode" style="width:140px;"/>
									<div id="qrvalue" style="visibility: hidden;position:absolute;">
{"vkntckn":"<xsl:value-of select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID = 'TCKN' or @schemeID = 'VKN']"/>", 
"avkntckn":"<xsl:value-of select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID = 'TCKN' or @schemeID = 'VKN']"/><xsl:text> </xsl:text>",
"senaryo":"<xsl:value-of select="n1:Invoice/cbc:ProfileID"/>", 
"tip":"<xsl:value-of select="n1:Invoice/cbc:InvoiceTypeCode"/>", 
"tarih":"<xsl:value-of select="n1:Invoice/cbc:IssueDate"/>", 
"no":"<xsl:value-of select="n1:Invoice/cbc:ID"/>", 
"ettn":"<xsl:value-of select="n1:Invoice/cbc:UUID"/>", 
"parabirimi":"<xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>", 
"malhizmettoplam":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount"/><xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '0015']">"<xsl:text>, 
"kdvmatrah</xsl:text>(<xsl:value-of select="cbc:Percent"/>)":"<xsl:value-of select="cbc:TaxableAmount"/>"</xsl:for-each><xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '0015']"><xsl:text>, 
"hesaplanankdv</xsl:text>(<xsl:value-of select="cbc:Percent"/>)":"<xsl:value-of select="cbc:TaxAmount"/>",</xsl:for-each>
"vergidahil":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount"/>", 
"odenecek":"<xsl:value-of select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount"/>"}
									</div>
									<script type="text/javascript">
										var qrcode = new QRCode(document.getElementById("qrcode"), {
										width : 140,
										height : 140,
										correctLevel : QRCode.CorrectLevel.M
										});

										function makeCode (msg) {
										var elText = document.getElementById("text");

										qrcode.makeCode(msg);
										}

										makeCode(document.getElementById("qrvalue").innerHTML);
									</script>
									<br/>


								</td>

                </tr>
                <tr style="" valign="top">

                  <td width="40%" align="right" valign="bottom">

                    <table id="customerPartyTable" align="left" border="0"
                      height="50%">
                      <tbody>
                        <tr style="height:71px; ">
                          <td>
                            <hr/>
                            <table align="center" border="0">
                              <tbody>
                                <tr>
                                  <xsl:for-each select="n1:Invoice/cac:AccountingCustomerParty/cac:Party">
                                    <td style="width:469px; " align="left">
                                      <span style="font-weight:bold; ">
                                        <xsl:text>SAYIN</xsl:text>
                                      </span>
                                    </td>
                                  </xsl:for-each>
                                </tr>
                                <tr>
                                  <xsl:choose>
                                    <xsl:when test="n1:Invoice/cac:BuyerCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='PARTYTYPE']">
                                      <xsl:for-each select="n1:Invoice/cac:BuyerCustomerParty/cac:Party">
                                        <xsl:call-template name="Party_Title">
                                          <xsl:with-param name="PartyType">TAXFREE</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:for-each>
                                    </xsl:when>
                                    <xsl:otherwise>
                                      <xsl:for-each select="n1:Invoice/cac:AccountingCustomerParty/cac:Party">
                                        <xsl:call-template name="Party_Title">
                                          <xsl:with-param name="PartyType">OTHER</xsl:with-param>
                                        </xsl:call-template>
                                      </xsl:for-each>
                                    </xsl:otherwise>
                                  </xsl:choose>
                                </tr>

                                <xsl:choose>
                                  <xsl:when test="n1:Invoice/cac:BuyerCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='PARTYTYPE']">
                                    <xsl:for-each select="n1:Invoice/cac:BuyerCustomerParty/cac:Party">
                                      <tr>
                                        <xsl:call-template name="Party_Adress">
                                          <xsl:with-param name="PartyType">TAXFREE</xsl:with-param>
                                        </xsl:call-template>
                                      </tr>
                                      <xsl:call-template name="Party_Other">
                                        <xsl:with-param name="PartyType">TAXFREE</xsl:with-param>
                                      </xsl:call-template>
                                    </xsl:for-each>
                                  </xsl:when>
                                  <xsl:otherwise>
                                    <xsl:for-each select="n1:Invoice/cac:AccountingCustomerParty/cac:Party">
                                      <tr>
                                        <xsl:call-template name="Party_Adress">
                                          <xsl:with-param name="PartyType">OTHER</xsl:with-param>
                                        </xsl:call-template>
                                      </tr>
                                      <xsl:call-template name="Party_Other">
                                        <xsl:with-param name="PartyType">OTHER</xsl:with-param>
                                      </xsl:call-template>
                                    </xsl:for-each>
                                  </xsl:otherwise>
                                </xsl:choose>
                              </tbody>
                            </table>
                            <hr/>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                    <br/>
                    

                  </td>
                  <td width="60%" align="center" valign="bottom" colspan="3">
                    <table border="1" height="13" id="despatchTable">
                      <tbody>
                        <tr>
                          <td style="width:105px;" align="left">
                            <span style="font-weight:bold; ">
                              <xsl:text>Özelleştirme No:</xsl:text>
                            </span>
                          </td>
                          <td style="width:110px;" align="left">
                            <xsl:for-each select="n1:Invoice/cbc:CustomizationID">
                              <xsl:apply-templates/>
                            </xsl:for-each>
                          </td>
                        </tr>
                        <tr style="height:13px; ">
                          <td align="left">
                            <span style="font-weight:bold; ">
                              <xsl:text>Senaryo:</xsl:text>
                            </span>
                          </td>
                          <td align="left">
                            <xsl:for-each select="n1:Invoice/cbc:ProfileID">
                              <xsl:apply-templates/>
                            </xsl:for-each>
                          </td>
                        </tr>
                        <tr style="height:13px; ">
                          <td align="left">
                            <span style="font-weight:bold; ">
                              <xsl:text>Fatura Tipi:</xsl:text>
                            </span>
                          </td>
                          <td align="left">
                            <xsl:for-each select="n1:Invoice/cbc:InvoiceTypeCode">
                              <xsl:apply-templates/>
                            </xsl:for-each>
                          </td>
                        </tr>
                        <tr style="height:13px; ">
                          <td align="left">
                            <span style="font-weight:bold; ">
                              <xsl:text>Fatura No:</xsl:text>
                            </span>
                          </td>
                          <td align="left">
                            <xsl:for-each select="n1:Invoice/cbc:ID">
                              <xsl:apply-templates/>
                            </xsl:for-each>
                          </td>
                        </tr>
                        <tr style="height:13px; ">
                          <td align="left">
                            <span style="font-weight:bold; ">
                              <xsl:text>Fatura Tarihi:</xsl:text>
                            </span>
                          </td>
                          <td align="left">
                            <xsl:for-each select="n1:Invoice/cbc:IssueDate">
                              <xsl:apply-templates select="."/>
                            </xsl:for-each>
                          </td>
                        </tr>
                        <xsl:for-each select="n1:Invoice/cac:DespatchDocumentReference">
                          <tr style="height:13px; ">
                            <td align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>İrsaliye No:</xsl:text>
                              </span>
                              <xsl:text>&#160;</xsl:text>
                            </td>
                            <td align="left">
                              <xsl:value-of select="cbc:ID"/>
                            </td>
                          </tr>
                          <tr style="height:13px; ">
                            <td align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>İrsaliye Tarihi:</xsl:text>
                              </span>
                            </td>
                            <td align="left">
                              <xsl:for-each select="cbc:IssueDate">
                                <xsl:apply-templates select="."/>
                              </xsl:for-each>
                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:if test="//n1:Invoice/cac:OrderReference">
                          <tr style="height:13px">
                            <td align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>Sipariş No:</xsl:text>
                              </span>
                            </td>
                            <td align="left">
                              <xsl:for-each select="n1:Invoice/cac:OrderReference/cbc:ID">
                                <xsl:apply-templates/>
                              </xsl:for-each>
                            </td>
                          </tr>
                        </xsl:if>
                        <xsl:if  test="//n1:Invoice/cac:OrderReference/cbc:IssueDate">
                          <tr style="height:13px">
                            <td align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>Sipariş Tarihi:</xsl:text>
                              </span>
                            </td>
                            <td align="left">
                              <xsl:for-each select="n1:Invoice/cac:OrderReference/cbc:IssueDate">
                                <xsl:apply-templates select="."/>
                              </xsl:for-each>
                            </td>
                          </tr>
                        </xsl:if>
                        <xsl:for-each select="n1:Invoice/cac:TaxRepresentativeParty/cac:PartyIdentification/cbc:ID[@schemeID='ARACIKURUMVKN']">
                          <tr>
                            <td style="width:105px;" align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>Aracı Kurum VKN:</xsl:text>
                              </span>
                            </td>
                            <td style="width:110px;" align="left">
                              <xsl:value-of select="."/>
                            </td>
                          </tr>
                          <tr>
                            <td style="width:105px;" align="left">
                              <span style="font-weight:bold; ">
                                <xsl:text>Aracı Kurum Unvan:</xsl:text>
                              </span>
                            </td>
                            <td style="width:110px;" align="left">
                              <xsl:value-of select="../../cac:PartyName/cbc:Name"/>
                            </td>
                          </tr>
                        </xsl:for-each>
                      </tbody>
                    </table>
                  </td>
                </tr>
                <tr align="left">
                  <table id="ettnTable">
                    <tr style="height:13px;">
                      <td align="left" valign="top">
                        <span style="font-weight:bold; ">
                          <xsl:text>ETTN:</xsl:text>
                        </span>
                      </td>
                      <td align="left" width="240px">
                        <xsl:for-each select="n1:Invoice/cbc:UUID">
                          <xsl:apply-templates/>
                        </xsl:for-each>
                      </td>
                    </tr>

                  </table>
                </tr>
              </tbody>
            </table>
            <div id="lineTableAligner">
              <span>
                <xsl:text>&#160;</xsl:text>
              </span>
            </div>
            <table border="1" id="lineTable" width="800">
              <tbody>
                <tr id="lineTableTr">
                  <td id="lineTableTd" style="width:10%">
                    <span style="font-weight:bold; " align="center">
                      <xsl:text>Kod</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:37%" align="center">
                    <span style="font-weight:bold; ">
                      <xsl:text>Mal Hizmet</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:12.4%" align="center">
                    <span style="font-weight:bold;">
                      <xsl:text>Miktar</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:14%" align="center">
                    <span style="font-weight:bold; ">
                      <xsl:text>Birim Fiyat</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:7%" align="center">
                    <span style="font-weight:bold; ">
                      <xsl:text>İskonto Oranı</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:9%" align="center">
                    <span style="font-weight:bold; ">
                      <xsl:text>İskonto Tutarı</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableTd" style="width:10.6%" align="center">
                    <span style="font-weight:bold; ">
                      <xsl:text>Mal Hizmet Tutarı</xsl:text>
                    </span>
                  </td>
                  <xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">

                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:PackagingTypeCode">
                      <th>
                        <span>
                          <xsl:text>Eşya Kap Cinsi</xsl:text>
                        </span>
                      </th> 
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:ID">
                      <th>
                        <span>
                          <xsl:text>Kap No</xsl:text>
                        </span>
                      </th>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:Quantity">
                      <th>
                        <span>
                          <xsl:text>Kap Adet</xsl:text>
                        </span>
                      </th> 
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:DeliveryAddress">
                      <th>
                        <span>
                          <xsl:text>Teslim/Bedel Ödeme Yeri</xsl:text>
                        </span>
                      </th>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:Shipment/cac:ShipmentStage/cbc:TransportModeCode">
                      <th>
                        <span>
                          <xsl:text>Gönderilme Şekli</xsl:text>
                        </span>
                      </th>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:Delivery/cac:Shipment/cac:GoodsItem/cbc:RequiredCustomsID">
                      <th>
                        <span>
                          <xsl:text>GTİP</xsl:text>
                        </span>
                      </th> 
                    </xsl:if>
                  </xsl:if>
                </tr>
                <xsl:for-each select="//n1:Invoice/cac:InvoiceLine">
                  <xsl:apply-templates select="."/>
                </xsl:for-each>
                
              </tbody>
            </table>
          </xsl:for-each>
          <table id="budgetContainerTable" width="800px">
            <tr id="budgetContainerTr" align="right">
              <td id="budgetContainerDummyTd"/>
              <td id="lineTableBudgetTd" align="right" width="400px">
                <span style="font-weight:bold; ">
                  <xsl:text>Mal Hizmet Toplam Tutarı</xsl:text>
                </span>
              </td>
              <td id="lineTableBudgetTd" style="width:81px; " align="right">
                <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount">
                  <xsl:call-template name="Curr_Type"/>
                </xsl:for-each>
              </td>
            </tr>
            <xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
              <xsl:if test="cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '4171'">
                <tr id="budgetContainerTr" align="right">
                  <td id="budgetContainerDummyTd"/>
                  <td id="lineTableBudgetTd" align="right" width="400px">
                    <span style="font-weight:bold; ">
                      <xsl:text>Teslim Bedeli</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableBudgetTd" style="width:81px; " align="right">
                    <xsl:for-each select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount">
                      <xsl:call-template name="Curr_Type"/>
                    </xsl:for-each>
                  </td>
                </tr>
              </xsl:if>
            </xsl:for-each>
            <tr id="budgetContainerTr" align="right">
              <td id="budgetContainerDummyTd"/>
              <td id="lineTableBudgetTd" align="right" width="400px">
                <span style="font-weight:bold; ">
                  <xsl:text>Toplam İskonto</xsl:text>
                </span>
              </td>
              <td id="lineTableBudgetTd" style="width:81px; " align="right">
                <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount">
                  <xsl:call-template name="Curr_Type"/>
                </xsl:for-each>
              </td>
            </tr>
            <xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
              <tr id="budgetContainerTr" align="right">
                <td id="budgetContainerDummyTd"/>
                <td id="lineTableBudgetTd" align="right" width="400px">
                  <span style="font-weight:bold; ">
                    <xsl:text>Kdv Matrah:</xsl:text>
                    <xsl:value-of  select="format-number(cbc:TaxableAmount, '###.##0,00', 'european')"/>
                    <xsl:if test="cbc:TaxAmount/@currencyID">
                      <xsl:text> </xsl:text>
                      <xsl:if test="cbc:TaxAmount/@currencyID = 'TRL' or cbc:TaxAmount/@currencyID = 'TRY'">
                        <xsl:text>TL</xsl:text>
                      </xsl:if>
                      <xsl:if test="cbc:TaxAmount/@currencyID != 'TRL' and cbc:TaxAmount/@currencyID != 'TRY'">
                        <xsl:value-of select="cbc:TaxAmount/@currencyID"/>
                      </xsl:if>
                    </xsl:if>
                    <xsl:text> | Hesaplanan </xsl:text>
                    <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
                    <xsl:text>(%</xsl:text>
                    <xsl:value-of select="cbc:Percent"/>
                    <xsl:text>)</xsl:text>
                  </span>
                </td>
                <td id="lineTableBudgetTd" style="width:82px; " align="right">
                  <xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
                    <xsl:text> </xsl:text>
                    <xsl:value-of  select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
                    <xsl:if test="../../cbc:TaxAmount/@currencyID">
                      <xsl:text> </xsl:text>
                      <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRL' or ../../cbc:TaxAmount/@currencyID = 'TRY'">
                        <xsl:text>TL</xsl:text>
                      </xsl:if>
                      <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRL' and ../../cbc:TaxAmount/@currencyID != 'TRY'">
                        <xsl:value-of select="../../cbc:TaxAmount/@currencyID"/>
                      </xsl:if>
                    </xsl:if>
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
            <xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
              <xsl:if test="cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode = '4171'">
                <tr id="budgetContainerTr" align="right">
                  <td id="budgetContainerDummyTd"/>
                  <td id="lineTableBudgetTd" align="right" width="400px">
                    <span style="font-weight:bold; ">
                      <xsl:text>KDV Matrahı</xsl:text>
                    </span>
                  </td>
                  <td id="lineTableBudgetTd" style="width:81px; " align="right">
                    <xsl:value-of
                      select="format-number(sum(//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=0015]/cbc:TaxableAmount), '###.##0,00', 'european')"/>
                      <xsl:if
                        test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID">
                        <xsl:text> </xsl:text>
                        <xsl:if
                          test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID = 'TRL' or //n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID = 'TRY'">
                          <xsl:text>TL</xsl:text>
                        </xsl:if>
                        <xsl:if
                          test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID != 'TRL' and //n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID != 'TRY'">
                          <xsl:value-of
                            select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID"
                            />
                          </xsl:if>
                        </xsl:if>
                      </td>
                    </tr>
                    <tr id="budgetContainerTr" align="right">
                      <td id="budgetContainerDummyTd"/>
                      <td id="lineTableBudgetTd" align="right" width="400px">
                        <span style="font-weight:bold; ">
                          <xsl:text>Tevkifat Dahil Toplam Tutar</xsl:text>
                        </span>
                      </td>
                      <td id="lineTableBudgetTd" style="width:81px; " align="right">
                        <xsl:for-each select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount">
                          <xsl:call-template name="Curr_Type"/>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr id="budgetContainerTr" align="right">
                      <td id="budgetContainerDummyTd"/>
                      <td id="lineTableBudgetTd" align="right" width="400px">
                        <span style="font-weight:bold; ">
                          <xsl:text>Tevkifat Hariç Toplam Tutar</xsl:text>
                        </span>
                      </td>
                      <td id="lineTableBudgetTd" style="width:81px; " align="right">
                        <xsl:for-each select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount">
                          <xsl:call-template name="Curr_Type"/>
                        </xsl:for-each>
                      </td>
                    </tr>
                  </xsl:if>
                </xsl:for-each>
                <xsl:for-each select="n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal">
                  <tr id="budgetContainerTr" align="right">
                    <td id="budgetContainerDummyTd"/>
                    <td id="lineTableBudgetTd" align="right" width="400px">
                      <span style="font-weight:bold; ">
                        <xsl:text>Tvf. Kdv Matrah:</xsl:text>
                        <xsl:value-of  select="format-number(cbc:TaxableAmount, '###.##0,00', 'european')"/>
                        <xsl:if test="cbc:TaxAmount/@currencyID">
                          <xsl:text> </xsl:text>
                          <xsl:if test="cbc:TaxAmount/@currencyID = 'TRL' or cbc:TaxAmount/@currencyID = 'TRY'">
                            <xsl:text>TL</xsl:text>
                          </xsl:if>
                          <xsl:if test="cbc:TaxAmount/@currencyID != 'TRL' and cbc:TaxAmount/@currencyID != 'TRY'">
                            <xsl:value-of select="cbc:TaxAmount/@currencyID"/>
                          </xsl:if>
                        </xsl:if>
                        <xsl:text> | Hesaplanan KDV Tevkifat</xsl:text>
                        <xsl:text>(%</xsl:text>
                        <xsl:value-of select="cbc:Percent"/>
                        <xsl:text>)</xsl:text>
						<br />
						<span style="color:blue; ">
						<xsl:text>(Not: Tevkif edilen KDV</xsl:text>
                        <xsl:text>(%</xsl:text>
                        <xsl:value-of select="100 - cbc:Percent"/>
                        <xsl:text>) = </xsl:text>
						<xsl:value-of select="format-number(((cbc:TaxAmount div cbc:Percent) * (100 - cbc:Percent) ), '###.##0,00', 'european')"/>
						<xsl:if test="cbc:TaxAmount/@currencyID">
                          <xsl:text> </xsl:text>
                          <xsl:if test="cbc:TaxAmount/@currencyID = 'TRL' or cbc:TaxAmount/@currencyID = 'TRY'">
                            <xsl:text>TL</xsl:text>
                          </xsl:if>
                          <xsl:if test="cbc:TaxAmount/@currencyID != 'TRL' and cbc:TaxAmount/@currencyID != 'TRY'">
                            <xsl:value-of select="cbc:TaxAmount/@currencyID"/>
                          </xsl:if>
                        </xsl:if>
						<xsl:text> )</xsl:text>
                        </span>
                      </span>
                    </td>
                    <td id="lineTableBudgetTd" style="width:82px; " align="right">
                      <xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
                        <xsl:text> </xsl:text>
                        <xsl:value-of
                          select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
                          <xsl:if test="../../cbc:TaxAmount/@currencyID">
                            <xsl:text> </xsl:text>
                            <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRL' or ../../cbc:TaxAmount/@currencyID = 'TRY'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRL' and ../../cbc:TaxAmount/@currencyID != 'TRY'">
                              <xsl:value-of select="../../cbc:TaxAmount/@currencyID"/>
                            </xsl:if>
                          </xsl:if>
                        </xsl:for-each>
                      </td>
                    </tr>
                  </xsl:for-each>
                  <xsl:if
                    test="sum(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:TaxableAmount)>0">
                    <tr id="budgetContainerTr" align="right">
                      <td id="budgetContainerDummyTd"/>
                      <td id="lineTableBudgetTd" align="right" width="400px">
                        <span style="font-weight:bold; ">
                          <xsl:text>Tevkifata Tabi İşlem Tutarı</xsl:text>
                        </span>
                      </td>
                      <td id="lineTableBudgetTd" style="width:82px; " align="right">
                        <xsl:value-of
                          select="format-number(sum(n1:Invoice/cac:InvoiceLine[cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:LineExtensionAmount), '###.##0,00', 'european')"/>
                          <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                            <xsl:text>TL</xsl:text>
                          </xsl:if>
                          <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                            <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                          </xsl:if>
                        </td>
                      </tr>
                      <tr id="budgetContainerTr" align="right">
                        <td id="budgetContainerDummyTd"/>
                        <td id="lineTableBudgetTd" align="right" width="400px">
                          <span style="font-weight:bold; ">
                            <xsl:text>Tevkifata Tabi İşlem Üzerinden Hes. KDV</xsl:text>
                          </span>
                        </td>
                        <td id="lineTableBudgetTd" style="width:82px; " align="right">
                          <xsl:value-of
                            select="format-number(sum(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:TaxableAmount), '###.##0,00', 'european')"/>
                            <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                            </xsl:if>
                          </td>
                        </tr>
                      </xsl:if>
                      <xsl:if test = "n1:Invoice/cac:InvoiceLine[cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme]">
                        <tr id="budgetContainerTr" align="right">
                          <td id="budgetContainerDummyTd"/>
                          <td id="lineTableBudgetTd" align="right" width="400px">
                            <span style="font-weight:bold; ">
                              <xsl:text>Tevkifata Tabi İşlem Tutarı</xsl:text>
                            </span>
                          </td>
                          <td id="lineTableBudgetTd" style="width:82px; " align="right">
                            <xsl:if test = "n1:Invoice/cac:InvoiceLine[cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme]">
                              <xsl:value-of
                                select="format-number(sum(n1:Invoice/cac:InvoiceLine[cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme]/cbc:LineExtensionAmount), '###.##0,00', 'european')"/>
                              </xsl:if>
                              <xsl:if test = "//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=&apos;9015&apos;">
                                <xsl:value-of
                                  select="format-number(sum(n1:Invoice/cac:InvoiceLine[cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:LineExtensionAmount), '###.##0,00', 'european')"/>
                                </xsl:if>
                                <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode = 'TRL' or n1:Invoice/cbc:DocumentCurrencyCode = 'TRY'">
                                  <xsl:text>TL</xsl:text>
                                </xsl:if>
                                <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode != 'TRL' and n1:Invoice/cbc:DocumentCurrencyCode != 'TRY'">
                                  <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                                </xsl:if>
                              </td>
                            </tr>
                            <tr id="budgetContainerTr" align="right">
                              <td id="budgetContainerDummyTd"/>
                              <td id="lineTableBudgetTd" align="right" width="400px">
                                <span style="font-weight:bold; ">
                                  <xsl:text>Tevkifata Tabi İşlem Üzerinden Hes. KDV</xsl:text>
                                </span>
                              </td>
                              <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                <xsl:if test = "n1:Invoice/cac:InvoiceLine[cac:WithholdingTaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme]">
                                  <xsl:value-of
                                    select="format-number(sum(n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme]/cbc:TaxableAmount), '###.##0,00', 'european')"/>
                                  </xsl:if>
                                  <xsl:if test = "//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=&apos;9015&apos;">
                                    <xsl:value-of
                                      select="format-number(sum(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:TaxableAmount), '###.##0,00', 'european')"/>
                                    </xsl:if>
                                    <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode = 'TRL' or n1:Invoice/cbc:DocumentCurrencyCode = 'TRY'">
                                      <xsl:text>TL</xsl:text>
                                    </xsl:if>
                                    <xsl:if test="n1:Invoice/cbc:DocumentCurrencyCode != 'TRL' and n1:Invoice/cbc:DocumentCurrencyCode != 'TRY'">
                                      <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                                    </xsl:if>
                                  </td>
                                </tr>
                              </xsl:if>
                              <tr id="budgetContainerTr" align="right">
                                <td id="budgetContainerDummyTd"/>
                                <td id="lineTableBudgetTd" align="right" width="400px">
                                  <span style="font-weight:bold; ">
                                    <xsl:text>Vergiler Dahil Toplam Tutar</xsl:text>
                                  </span>
                                </td>
                                <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                  <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount">
                                    <xsl:call-template name="Curr_Type"/>
                                  </xsl:for-each>
                                </td>
                              </tr>
                              <tr id="budgetContainerTr" align="right">
                                <td id="budgetContainerDummyTd"/>
                                <td id="lineTableBudgetTd" align="right" width="400px">
                                  <span style="font-weight:bold; ">
                                    <xsl:text>Ödenecek Tutar</xsl:text>
                                  </span>
                                </td>
                                <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                  <xsl:for-each select="n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount">
                                    <xsl:call-template name="Curr_Type"/>
                                  </xsl:for-each>
                                </td>
                              </tr>
                              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY'">
                                <tr id="budgetContainerTr" align="right">
                                  <td id="budgetContainerDummyTd"/>
                                  <td id="lineTableBudgetTd" align="right" width="400px">
                                    <span style="font-weight:bold; ">
                                      <xsl:text>Toplam İskonto (TL)</xsl:text>
                                    </span>
                                  </td>
                                  <td id="lineTableBudgetTd" style="width:81px; " align="right">
                                    <span>
                                      <xsl:value-of select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                      <xsl:text> TL</xsl:text>
                                    </span>
                                  </td>
                                </tr>
                              </xsl:if>
                              <xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal">
                                <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY'">
                                  <tr align="right">
                                    <td/>
                                    <td id="lineTableBudgetTd" align="right" width="400px">
                                      <span style="font-weight:bold; ">
                                        <xsl:text>Kdv Matrah:</xsl:text>
                                        <xsl:value-of  select="format-number(cbc:TaxableAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                        <xsl:text> TL</xsl:text>
                                        <xsl:text> | Hesaplanan </xsl:text>
                                        <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
                                        <xsl:text>(%</xsl:text>
                                        <xsl:value-of select="cbc:Percent"/>
                                        <xsl:text>) (TL)</xsl:text>
                                      </span>
                                    </td>
                                    <td id="lineTableBudgetTd" style="width:81px; " align="right">
                                      <span>
                                        <xsl:value-of select="format-number(cbc:TaxAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                        <xsl:text> TL</xsl:text>
                                      </span>
                                    </td>
                                  </tr>
                                </xsl:if>
                              </xsl:for-each>
                              <xsl:for-each select="n1:Invoice/cac:WithholdingTaxTotal/cac:TaxSubtotal">
                                <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and cbc:TaxAmount != ''">
                                  <tr id="budgetContainerTr" align="right">
                                    <td/>
                                    <td id="lineTableBudgetTd" align="right" width="400px">
                                      <span style="font-weight:bold; ">
                                       <xsl:text>Kdv Matrah:</xsl:text>
                                       <xsl:value-of  select="format-number(cbc:TaxableAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                       <xsl:text> TL</xsl:text>
                                       <xsl:text> | KDV Tevkifat-[</xsl:text>
                                       <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode"/> 
                                       <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
                                       <xsl:text>]-</xsl:text>
                                       <xsl:text>(%</xsl:text>
                                       <xsl:value-of select="cbc:Percent"/>
                                       <xsl:text>) (TL)</xsl:text>
                                     </span>
									 <br />
										<span style="color:blue; font-weight:bold;">
										<xsl:text>(Not: Tevkif edilen KDV</xsl:text>
										<xsl:text>(%</xsl:text>
										<xsl:value-of select="100 - cbc:Percent"/>
										<xsl:text>) = </xsl:text>
										<xsl:value-of select="format-number(((cbc:TaxAmount div cbc:Percent) * (100 - cbc:Percent)) * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
										<xsl:text> TL</xsl:text>
										
										</span>
                                   </td>
                                   <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                    <xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
                                      <xsl:text> </xsl:text>
                                      <xsl:value-of select="format-number(../../cbc:TaxAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                      <xsl:text> TL</xsl:text>
                                    </xsl:for-each>
                                  </td>
                                </tr>
                              </xsl:if>
                            </xsl:for-each>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY'">
                              <tr align="right">
                                <td/>
                                <td id="lineTableBudgetTd" align="right" width="400px">
                                  <span style="font-weight:bold; ">
                                    <xsl:text>Mal Hizmet Toplam Tutarı(TL)</xsl:text>
                                  </span>
                                </td>
                                <td id="lineTableBudgetTd" style="width:81px; " align="right">
                                  <span>
                                    <xsl:value-of select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                    <xsl:text> TL</xsl:text>
                                  </span>
                                </td>
                              </tr>
                              <tr id="budgetContainerTr" align="right">
                                <td/>
                                <td id="lineTableBudgetTd" align="right" width="400px">
                                  <span style="font-weight:bold; ">
                                    <xsl:text>Vergiler Dahil Toplam Tutar(TL)</xsl:text>
                                  </span>
                                </td>
                                <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                  <xsl:value-of select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                  <xsl:text> TL</xsl:text>
                                </td>
                              </tr>
                              <tr align="right">
                                <td/>
                                <td id="lineTableBudgetTd" align="right" width="400px">
                                  <span style="font-weight:bold; ">
                                    <xsl:text>Ödenecek Tutar(TL)</xsl:text>
                                  </span>
                                </td>
                                <td id="lineTableBudgetTd" style="width:82px; " align="right">
                                  <xsl:value-of select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount * //n1:Invoice/cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
                                  <xsl:text> TL</xsl:text>
                                </td>
                              </tr>
                            </xsl:if>
                          </table>
                          <br/>
                          <xsl:if test="//n1:Invoice/cac:BillingReference/cac:InvoiceDocumentReference/cbc:DocumentType[translate(text(),'abcçdefgğhıijklmnoöpqrsştuüvwxyz','ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ')='FATURA']">
					<table id="lineTable" class="fixedTableCss" width="800">
						<thead>
							<tr id="lineTableTr">
								<td class="lineTableTd" align="center" colspan="2">
									<span style="font-weight:bold; ">İadeye Konu Olan Faturalar</span>
								</td>
							</tr>
						</thead>
						<tbody>
							<tr id="lineTableTr" align="left">
								<td class="lineTableTd">
									<span style="font-weight:bold; " align="center">&#xA0;&#xA0;&#xA0;&#xA0;&#xA0;Fatura No</span>
								</td>
								<td class="lineTableTd">
									<span style="font-weight:bold; " align="center">&#xA0;&#xA0;&#xA0;&#xA0;&#xA0;Tarih</span>
								</td>
							</tr>
							<xsl:for-each select="//n1:Invoice/cac:BillingReference/cac:InvoiceDocumentReference/cbc:DocumentType[translate(text(),'abcçdefgğhıijklmnoöpqrsştuüvwxyz','ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ')='FATURA']">
								<tr id="lineTableTr" align="left">
									<td class="lineTableTd">
										&#xA0;&#xA0;&#xA0;&#xA0;&#xA0; <xsl:value-of select="../cbc:ID"/>
									</td>
									<td class="lineTableTd">
										&#xA0;&#xA0;&#xA0;&#xA0;&#xA0; <xsl:for-each select="../cbc:IssueDate">
											<xsl:apply-templates select="."/>
										</xsl:for-each>
									</td>
								</tr>
							</xsl:for-each>
						</tbody>
					</table>
					<br/>
				</xsl:if>
				<xsl:if test="//n1:Invoice/cac:BillingReference/cac:AdditionalDocumentReference/cbc:DocumentTypeCode='OKCBF'">
					<table id="lineTable" class="fixedTableCss" width="800" border="1">
						<thead>
							<tr>
								<th colspan="6">ÖKC Bilgileri</th>
							</tr>
						</thead>
						<tbody>
							<tr id="okcbfHeadTr" style="font-weight:bold;">
								<td style="width:20%">
									<xsl:text>Fiş Numarası</xsl:text>
								</td>
								<td style="width:10%" align="center">
									<xsl:text>Fiş Tarihi</xsl:text>
								</td>
								<td style="width:10%" align="center">
									<xsl:text>Fiş Saati</xsl:text>
								</td>
								<td style="width:40%" align="center">
									<xsl:text>Fiş Tipi</xsl:text>
								</td>
								<td style="width:10%" align="center">
									<xsl:text>Z Rapor No</xsl:text>
								</td>
								<td style="width:10%" align="center">
									<xsl:text>ÖKC Seri No</xsl:text>
								</td>
							</tr>
						</tbody>
						<xsl:for-each select="//n1:Invoice/cac:BillingReference/cac:AdditionalDocumentReference/cbc:DocumentTypeCode[text()='OKCBF']">
							<tr>
								<td style="width:20%">
									<xsl:value-of select="../cbc:ID"/>
								</td>
								<td style="width:10%" align="center">
									<xsl:value-of select="../cbc:IssueDate"/>
								</td>
								<td style="width:10%" align="center">
									<xsl:value-of select="substring(../cac:ValidityPeriod/cbc:StartTime,1,5)"/>
								</td>
								<td style="width:40%" align="center">
									<xsl:choose>
										<xsl:when test="../cbc:DocumentDescription='AVANS'">
											<xsl:text>Ön Tahsilat(Avans) Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='YEMEK_FIS'">
											<xsl:text>Yemek Fişi/Kartı ile Yapılan Tahsilat Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='E-FATURA'">
											<xsl:text>E-Fatura Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='E-FATURA_IRSALIYE'">
											<xsl:text>İrsaliye Yerine Geçen E-Fatura Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='E-ARSIV'">
											<xsl:text>E-Arşiv Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='E-ARSIV_IRSALIYE'">
											<xsl:text>İrsaliye Yerine Geçen E-Arşiv Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='FATURA'">
											<xsl:text>Faturalı Satış Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='OTOPARK'">
											<xsl:text>Otopark Giriş Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='FATURA_TAHSILAT'">
											<xsl:text>Fatura Tahsilat Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:when test="../cbc:DocumentDescription='FATURA_TAHSILAT_KOMISYONLU'">
											<xsl:text>Komisyonlu Fatura Tahsilat Bilgi Fişi</xsl:text>
										</xsl:when>
										<xsl:otherwise>
											<xsl:text> </xsl:text>
										</xsl:otherwise>
									</xsl:choose>
								</td>
								<td style="width:10%" align="center">
									<xsl:value-of select="../cac:Attachment/cac:ExternalReference/cbc:URI"/>
								</td>
								<td style="width:10%" align="center">
									<xsl:value-of select="../cac:IssuerParty/cbc:EndpointID"/>
								</td>
							</tr>
						</xsl:for-each>
					</table>
					<br/>
				</xsl:if>
				<xsl:if test="count(//n1:Invoice/cac:DespatchDocumentReference/cbc:ID) &gt; 1">
					<table id="despatchDocumentReferenceTable" class="fixedTableCss" width="800">
						<tr>
							<td align="left" style="padding: 4px 5px; border: 2px solid black;width:145px;">
								<span style="font-weight:bold; ">
									<xsl:text>İrsaliye No ve Tarihleri :</xsl:text>
								</span>
							</td>
							<td style="padding: 4px 5px; border: 2px solid black;">
								<xsl:for-each select="//n1:Invoice/cac:DespatchDocumentReference">
									<xsl:if test="cbc:ID !='' and cbc:IssueDate !=''">
										<xsl:value-of select="cbc:ID"/>
										<xsl:text>&#xA0;&#xA0;(</xsl:text>
										<xsl:value-of select="substring(cbc:IssueDate,9,2)"/>-<xsl:value-of select="substring(cbc:IssueDate,6,2)"/>-<xsl:value-of select="substring(cbc:IssueDate,1,4)"/>
										<xsl:text>)</xsl:text>
										<xsl:if test="position() != last()">
											<xsl:text>&#xA0;&#xA0;|&#xA0;&#xA0;</xsl:text>
										</xsl:if>
									</xsl:if>
								</xsl:for-each>
							</td>
						</tr>
					</table>
					<br/>
				</xsl:if>
                          <table id="notesTable" width="800" align="left" height="100">
                            <tbody>
                              <tr align="left">
                                <td id="notesTableTd">

                                  <xsl:if test="//n1:Invoice/cac:PaymentMeans/cbc:InstructionNote">
                                    <b>&#160;&#160;&#160;&#160;&#160; Ödeme Notu: </b>
                                    <xsl:value-of
                                      select="//n1:Invoice/cac:PaymentMeans/cbc:InstructionNote"/>
                                      <br/>
                                    </xsl:if>

                                    <xsl:if
                                      test="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote">
                                      <b>&#160;&#160;&#160;&#160;&#160; Hesap Açıklaması: </b>
                                      <xsl:value-of
                                        select="//n1:Invoice/cac:PaymentMeans/cac:PayeeFinancialAccount/cbc:PaymentNote"/>
                                        <br/>
                                      </xsl:if>
                                      <xsl:if test="//n1:Invoice/cac:PaymentTerms/cbc:Note">
                                        <b>&#160;&#160;&#160;&#160;&#160; Ödeme Koşulu: </b>
                                        <xsl:value-of select="//n1:Invoice/cac:PaymentTerms/cbc:Note"/>
                                        <br/>
                                      </xsl:if>
                                      <b>
                                        &#160;&#160;&#160;&#160;&#160; Yalnız:
                                      </b>#
                                      <xsl:for-each select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount">
                                        <xsl:call-template name="dovizi_oku">
                                          <xsl:with-param name="doviz" select="@currencyID" />
                                        </xsl:call-template>
                                      </xsl:for-each>#
                                      <br/>

                                      <xsl:for-each select="//n1:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal">
                                        <xsl:if
                                          test="cbc:TaxAmount=0 and cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=&apos;0015&apos;">
                                          <b>
                                            &#160;&#160;&#160;&#160;&#160; Vergi İstisna Muafiyet
                                            Sebebi:
                                          </b>
                                          <xsl:value-of
                                            select="cac:TaxCategory/cbc:TaxExemptionReason"/>
                                            <br/>
                                          </xsl:if>
                                        </xsl:for-each>
                                        <br/>
                                        <xsl:if test="//n1:Invoice/cbc:Note">
                                          <b>&#160;&#160;&#160;&#160;&#160; Notlar: </b>
                                          <br/>
                                          <xsl:for-each select="//n1:Invoice/cbc:Note[not(starts-with(text(), '#N#'))]">
                                            &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;
                                            <xsl:value-of select="."/>
                                            <br/>
                                          </xsl:for-each>
                                        </xsl:if>
                                        <br/>
                                        <table>
                                          <tr>
                                            <td style="border:solid 1px #000;">
                                              Banka bilgileri
                                            </td>
                                          </tr>
                                          <tr>
                                            <td style="border:solid 1px #000;">
                                              Akbank Bağcılar Şubesi. Şube Kodu: 435<br />
                                              SIWFT: AKBKTRIS435<br />
                                              <table border="0">
                                                <tr>
                                                  <td>TL:</td>
                                                  <td>TR52  0004 6004 3588 8000 2786 39</td>
                                                </tr>
                                                <tr>
                                                  <td>Euro:</td>
                                                  <td>TR63 0004 6004 3503 6000 2361 14</td>
                                                </tr>
                                                <tr>
                                                  <td>Dolar:</td>
                                                  <td>TR59 0004 6004 3500 1000 2361 15</td>
                                                </tr>
												<tr>
                                                  <td>GBP:</td>
                                                  <td>TR23 0004 6004 3500 3000 2646 31</td>
                                                </tr>
                                              </table>
                                            </td>
                                          </tr>
                                        </table>
										<br />
										İşbu fatura kapsamında ticari ilişkiniz gereği paylaşmış olduğunuz kişisel verileriniz 6698 Sayılı Kişisel Verilerin Korunması Kanunu’na uygun olarak, şirketimizce işlenmekte olup detaylı bilgiye https://www.reynaers.com.tr/tr adresinden ulaşabilirsiniz.
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </body>
                            </html>
                          </xsl:template>
                          <xsl:template match="//n1:Invoice/cac:InvoiceLine">
                            <tr id="lineTableTr">
                              <td id="lineTableTd">
                                <xsl:text>&#160;</xsl:text>
                                <xsl:value-of select="./cbc:ID"/>
                              </td>
                              <td id="lineTableTd">
                                <xsl:text>&#160;</xsl:text>
                                <xsl:value-of select="./cac:Item/cbc:Name"/>
                                <xsl:if  test="./cbc:Note">
                                  <xsl:if test="string-length(./cbc:Note) &gt; 0">
                                    <br/>
                                    <xsl:text>&#160;</xsl:text>
                                    <span style="font-size: 7pt;">
                                      (<xsl:value-of select="./cbc:Note"/>)
                                    </span>
                                  </xsl:if>
                                </xsl:if>
                              </td>
                              <td id="lineTableTd" align="right">
                                <xsl:text>&#160;</xsl:text>
                                <xsl:value-of
                                  select="format-number(./cbc:InvoicedQuantity, '###.###,####', 'european')"/>
                                  <xsl:if test="./cbc:InvoicedQuantity/@unitCode">
                                    <xsl:for-each select="./cbc:InvoicedQuantity">
                                      <xsl:text> </xsl:text>
                                      <xsl:choose>
                                        <xsl:when test="@unitCode  = '26'">
                                          <xsl:text>ton</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'BX'">
                                          <xsl:text>Kutu</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'LTR'">
                                          <xsl:text>lt</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'NIU'">
                                          <xsl:text>Adet</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'LN'">
                                          <xsl:text>Metre</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'KGM'">
                                          <xsl:text>kg</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'KJO'">
                                          <xsl:text>kJ</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'GRM'">
                                          <xsl:text>g</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MGM'">
                                          <xsl:text>mg</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'NT'">
                                          <xsl:text>Net Ton</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'GT'">
                                          <xsl:text>Gross Ton</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MTR'">
                                          <xsl:text>m</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MMT'">
                                          <xsl:text>mm</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'KTM'">
                                          <xsl:text>km</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MLT'">
                                          <xsl:text>ml</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MMQ'">
                                          <xsl:text>mm3</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'CLT'">
                                          <xsl:text>cl</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'CMK'">
                                          <xsl:text>cm2</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'CMQ'">
                                          <xsl:text>cm3</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'CMT'">
                                          <xsl:text>cm</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MTK'">
                                          <xsl:text>m2</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MTQ'">
                                          <xsl:text>m3</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'DAY'">
                                          <xsl:text> Gün</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'MON'">
                                          <xsl:text> Ay</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'PA'">
                                          <xsl:text> Paket</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'KWH'">
                                          <xsl:text> KWH</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'ANN'">
                                          <xsl:text> Yıl</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'HUR'">
                                          <xsl:text> Saat</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'D61'">
                                          <xsl:text> Dakika</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'D62'">
                                          <xsl:text> Saniye</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'CCT'">
                                          <xsl:text> Ton baş.taşıma kap.</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'D30'">
                                          <xsl:text> Brüt kalori</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'D40'">
                                          <xsl:text> 1000 lt</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'LPA'">
                                          <xsl:text> saf alkol lt</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'B32'">
                                          <xsl:text> kg.m2</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'NCL'">
                                          <xsl:text> hücre adet</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'PR'">
                                          <xsl:text> Çift</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'R9'">
                                          <xsl:text> 1000 m3</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'SET'">
                                          <xsl:text> Set</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'T3'">
                                          <xsl:text> 1000 adet</xsl:text>
                                        </xsl:when>
                                        <xsl:when test="@unitCode  = 'NPL'">
                                          <xsl:text> Koli</xsl:text>
                                        </xsl:when>
                                      </xsl:choose>
                                    </xsl:for-each>
                                  </xsl:if>
                                </td>
                                <td id="lineTableTd" align="right">
                                  <xsl:text>&#160;</xsl:text>
                                  <xsl:value-of
                                    select="format-number(./cac:Price/cbc:PriceAmount, '###.##0,########', 'european')"/>
                                    <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID">
                                      <xsl:text> </xsl:text>
                                      <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID = &quot;TRL&quot; or ./cac:Price/cbc:PriceAmount/@currencyID = &quot;TRY&quot;">
                                        <xsl:text>TL</xsl:text>
                                      </xsl:if>
                                      <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID != &quot;TRL&quot; and ./cac:Price/cbc:PriceAmount/@currencyID != &quot;TRY&quot;">
                                        <xsl:value-of select="./cac:Price/cbc:PriceAmount/@currencyID"/>
                                      </xsl:if>
                                    </xsl:if>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                    <xsl:for-each select="cac:AllowanceCharge">
                                      <xsl:choose>
                                        <xsl:when test="./cbc:MultiplierFactorNumeric">
                                          <xsl:text> %</xsl:text>
                                          <xsl:value-of select="format-number(./cbc:MultiplierFactorNumeric * 100, '###.##0,00', 'european')"/>
                                          <xsl:text> </xsl:text>
                                        </xsl:when>
                                        <xsl:otherwise>
                                          <xsl:text> </xsl:text>
                                        </xsl:otherwise>
                                      </xsl:choose>
                                    </xsl:for-each>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                    <xsl:for-each select="cac:AllowanceCharge/cbc:Amount">
                                      <xsl:call-template name="Curr_Type"/>
                                      <xsl:text> </xsl:text>
                                    </xsl:for-each>
                                  </td>

                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                    <xsl:for-each select="cbc:LineExtensionAmount">
                                      <xsl:call-template name="Curr_Type"/>
                                    </xsl:for-each>
                                  </td>
                                  <xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">

                    <xsl:if test="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:PackagingTypeCode">
                      <td id="lineTableTd">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:value-of select="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:PackagingTypeCode"/>
                      </td> 
                    </xsl:if>
                    <xsl:if test="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:ID">
                      <td id="lineTableTd">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:value-of select="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:ID"/>
                      </td> 
                    </xsl:if>
                    <xsl:if test="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:Quantity">
                      <td id="lineTableTd" align="right">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:value-of select="./cac:Delivery/cac:Shipment/cac:TransportHandlingUnit/cac:ActualPackage/cbc:Quantity"/>
                      </td> 
                    </xsl:if>
                    <xsl:if test="./cac:Delivery/cac:DeliveryAddress">
                      <td id="lineTableTd">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:value-of select="./cac:Delivery/cac:DeliveryAddress"/>
                      </td> 
                    </xsl:if>
                    <xsl:if test="./cac:Delivery/cac:Shipment/cac:ShipmentStage/cbc:TransportModeCode">
                      <td id="lineTableTd">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:for-each select="./cac:Delivery/cac:Shipment/cac:ShipmentStage/cbc:TransportModeCode">
                          <xsl:call-template name="TransportMode">
                            <xsl:with-param name="TransportModeType">
                              <xsl:value-of select="."/>
                            </xsl:with-param>
                          </xsl:call-template>
                        </xsl:for-each>
                      </td> 
                    </xsl:if>
                    <xsl:if test="./cac:Delivery/cac:Shipment/cac:GoodsItem/cbc:RequiredCustomsID">
                      <td id="lineTableTd">
                        <xsl:text>&#160;</xsl:text>
                        <xsl:value-of select="./cac:Delivery/cac:Shipment/cac:GoodsItem/cbc:RequiredCustomsID"/>
                      </td> 
                    </xsl:if>
                  </xsl:if>

                                </tr>
                              </xsl:template>
                              <xsl:template match="//cbc:IssueDate">
                                <xsl:value-of select="substring(.,9,2)"/>-<xsl:value-of select="substring(.,6,2)"/>-<xsl:value-of select="substring(.,1,4)"/>
                              </xsl:template>
                              <xsl:template match="//n1:Invoice">
                                <tr id="lineTableTr">
                                  <td id="lineTableTd">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                  <td id="lineTableTd" align="right">
                                    <xsl:text>&#160;</xsl:text>
                                  </td>
                                </tr>
                              </xsl:template>
                              <xsl:template name="Party_Title" >
                                <xsl:param name="PartyType" />
                                <td style="width:469px; " align="left">
                                  <xsl:if test="cac:PartyName">
                                    <xsl:value-of select="cac:PartyName/cbc:Name"/>
                                    <br/>
                                  </xsl:if>
                                  <xsl:for-each select="cac:Person">
                                    <xsl:for-each select="cbc:Title">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:FirstName">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:MiddleName">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160; </xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:FamilyName">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:NameSuffix">
                                      <xsl:apply-templates/>
                                    </xsl:for-each>
                                    <xsl:if test="$PartyType='TAXFREE'">
                                      <br/>
                                      <xsl:text>Pasaport No: </xsl:text>
                                      <xsl:value-of select="cac:IdentityDocumentReference/cbc:ID"/>
                                      <br/>
                                      <xsl:text>Ülkesi: </xsl:text>
                                      <xsl:value-of select="cbc:NationalityID"/>
                                    </xsl:if>
                                  </xsl:for-each>
                                </td>
                              </xsl:template>
                              <xsl:template name="Party_Adress" >
                                <xsl:param name="PartyType" />
                                <td style="width:469px; " align="left">
                                  <xsl:for-each select="cac:PostalAddress">
                                    <xsl:for-each select="cbc:StreetName">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:BuildingName">
                                      <xsl:apply-templates/>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:BuildingNumber">
                                      <xsl:text> No:</xsl:text>
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <br/>
                                    <xsl:for-each select="cbc:Room">
                                      <xsl:text>Kapı No:</xsl:text>
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <br/>
                                    <xsl:for-each select="cbc:PostalZone">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:CitySubdivisionName">
                                      <xsl:apply-templates/>
                                      <xsl:text>/ </xsl:text>
                                    </xsl:for-each>
                                    <xsl:for-each select="cbc:CityName">
                                      <xsl:apply-templates/>
                                      <xsl:text>&#160;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:if test="$PartyType='TAXFREE'">
                                      <br/>
                                      <xsl:value-of select="cac:Country/cbc:Name"/>
                                      <br/>
                                    </xsl:if>
                                  </xsl:for-each>
                                </td>
                              </xsl:template>
                              <xsl:template name='Party_Other'>
                                <xsl:param name="PartyType" />
                                <xsl:for-each select="cbc:WebsiteURI">
                                  <tr align="left">
                                    <td>
                                      <xsl:text>Web Sitesi: </xsl:text>
                                      <xsl:value-of select="."/>
                                    </td>
                                  </tr>
                                </xsl:for-each>
                                <xsl:for-each select="cac:Contact/cbc:ElectronicMail">
                                  <tr align="left">
                                    <td>
                                      <xsl:text>E-Posta: </xsl:text>
                                      <xsl:value-of select="."/>
                                    </td>
                                  </tr>
                                </xsl:for-each>
                                <xsl:for-each select="cac:Contact">
                                  <xsl:if test="cbc:Telephone or cbc:Telefax">
                                    <tr align="left">
                                      <td style="width:469px; " align="left">
                                        <xsl:for-each select="cbc:Telephone">
                                          <xsl:text>Tel: </xsl:text>
                                          <xsl:apply-templates/>
                                        </xsl:for-each>
                                        <xsl:for-each select="cbc:Telefax">
                                          <xsl:text> Fax: </xsl:text>
                                          <xsl:apply-templates/>
                                        </xsl:for-each>
                                        <xsl:text>&#160;</xsl:text>
                                      </td>
                                    </tr>
                                  </xsl:if>
                                </xsl:for-each>
                                <xsl:if test="$PartyType!='TAXFREE'">
                                  <xsl:for-each select="cac:PartyTaxScheme/cac:TaxScheme/cbc:Name">
                                    <tr align="left">
                                      <td>
                                        <xsl:text>Vergi Dairesi.: </xsl:text>
                                        <xsl:apply-templates/>
                                      </td>
                                    </tr>
                                  </xsl:for-each>
                                  <xsl:for-each select="cac:PartyIdentification">
                                    <tr align="left">
                                      <td>
                                        <xsl:value-of select="cbc:ID/@schemeID"/>
                                        <xsl:text>: </xsl:text>
                                        <xsl:value-of select="cbc:ID"/>
                                      </td>
                                    </tr>
                                  </xsl:for-each>
                                </xsl:if>
                              </xsl:template>
                              <xsl:template name="dovizi_oku">
                                <xsl:param name="doviz" />
                                <xsl:variable name="okunacak" select="." />
                                <xsl:variable name="noktadan_sonra" select="round(($okunacak - floor($okunacak)) * 100)" />
                                <xsl:call-template name="sayi_oku" >
                                  <xsl:with-param name="okunacak"  select="." />
                                </xsl:call-template>
                                <xsl:if test="$doviz">
                                  <xsl:choose>
                                    <xsl:when test="$doviz =  'TRL' or $doviz =  'TRY'">
                                      <xsl:value-of select="' Türk Lirası'" />
                                      <xsl:if test="$noktadan_sonra &gt; 0">
                                        <xsl:value-of select="' '" />
                                        <xsl:call-template name="sayi_oku" >
                                          <xsl:with-param name="okunacak"  select="$noktadan_sonra" />
                                        </xsl:call-template>
                                        <xsl:value-of select="' Kuruş'" />
                                      </xsl:if>
                                    </xsl:when>
                                    <xsl:otherwise>
                                      <xsl:text>&#160;</xsl:text>
                                      <xsl:value-of select="$doviz" />
                                      <xsl:if test="$noktadan_sonra &gt; 0">
                                        <xsl:value-of select="' '" />
                                        <xsl:call-template name="sayi_oku" >
                                          <xsl:with-param name="okunacak"  select="$noktadan_sonra" />
                                        </xsl:call-template>
                                        <xsl:value-of select="' Cent'" />
                                      </xsl:if>
                                    </xsl:otherwise>
                                  </xsl:choose>

                                </xsl:if>
                              </xsl:template>
                              <xsl:template name="sayi_oku">
                                <xsl:param name="okunacak" />
                                <xsl:variable name="tam_sayi" select="floor($okunacak)" />
                                <xsl:variable name="birler"   select="floor($okunacak) mod 10" />
                                <xsl:variable name="onlar"    select="floor(floor($tam_sayi mod 100) div 10)" />
                                <xsl:variable name="yuzler"   select="floor(floor($tam_sayi mod 1000) div 100)" />
                                <xsl:variable name="binler"   select="floor(floor($tam_sayi mod 1000000) div 1000)" />
                                <xsl:variable name="milyonlar"   select="floor(floor($tam_sayi mod 1000000000) div 1000000)" />
                                <xsl:variable name="milyarlar"   select="floor(floor($tam_sayi mod 1000000000000) div 1000000000)" />

                                <xsl:if test="$milyarlar &gt; 0">
                                  <xsl:call-template name="sayi_oku_3hane" >
                                    <xsl:with-param name="sayi"  select="$milyarlar" />
                                  </xsl:call-template> Milyar
                                </xsl:if>
                                <xsl:if test="$milyonlar &gt; 0">
                                  <xsl:call-template name="sayi_oku_3hane" >
                                    <xsl:with-param name="sayi"  select="$milyonlar" />
                                  </xsl:call-template> Milyon
                                </xsl:if>
                                <xsl:if test="$binler &gt; 0">
                                  <xsl:if test="$binler = 1">Bin </xsl:if>
                                  <xsl:if test="$binler > 1">
                                    <xsl:call-template name="sayi_oku_3hane" >
                                      <xsl:with-param name="sayi"  select="$binler" />
                                    </xsl:call-template> Bin
                                  </xsl:if>
                                </xsl:if>

                                <xsl:call-template name="yuzler_oku" >
                                  <xsl:with-param name="sayi"  select="$yuzler" />
                                </xsl:call-template>
                                <xsl:call-template name="onlar_oku" >
                                  <xsl:with-param name="sayi"  select="$onlar" />
                                </xsl:call-template>
                                <xsl:call-template name="birler_oku" >
                                  <xsl:with-param name="sayi"  select="$birler" />
                                </xsl:call-template>
                              </xsl:template>
                              <xsl:template name="sayi_oku_3hane">
                                <xsl:param name="sayi" />
                                <xsl:variable name="tam_sayi" select="floor($sayi)" />
                                <xsl:variable name="birler"   select="floor($sayi) mod 10" />
                                <xsl:variable name="onlar"    select="floor(floor($tam_sayi mod 100) div 10)" />
                                <xsl:variable name="yuzler"   select="floor(floor($tam_sayi mod 1000) div 100)" />
                                <xsl:call-template name="yuzler_oku" >
                                  <xsl:with-param name="sayi"  select="$yuzler" />
                                </xsl:call-template>
                                <xsl:call-template name="onlar_oku" >
                                  <xsl:with-param name="sayi"  select="$onlar" />
                                </xsl:call-template>
                                <xsl:call-template name="birler_oku" >
                                  <xsl:with-param name="sayi"  select="$birler" />
                                </xsl:call-template>
                              </xsl:template>
                              <xsl:template name="birler_oku">
                                <xsl:param name="sayi" />
                                <xsl:choose>
                                  <xsl:when test="$sayi =  1">Bir </xsl:when>
                                  <xsl:when test="$sayi =  2">İki </xsl:when>
                                  <xsl:when test="$sayi =  3">Üç </xsl:when>
                                  <xsl:when test="$sayi =  4">Dört </xsl:when>
                                  <xsl:when test="$sayi =  5">Beş </xsl:when>
                                  <xsl:when test="$sayi =  6">Altı </xsl:when>
                                  <xsl:when test="$sayi =  7">Yedi </xsl:when>
                                  <xsl:when test="$sayi =  8">Sekiz </xsl:when>
                                  <xsl:when test="$sayi =  9">Dokuz </xsl:when>
                                  <xsl:otherwise> </xsl:otherwise>
                                </xsl:choose>
                              </xsl:template>
                              <xsl:template name="onlar_oku">
                                <xsl:param name="sayi" />
                                <xsl:choose>
                                  <xsl:when test="$sayi =  1">On </xsl:when>
                                  <xsl:when test="$sayi =  2">Yirmi </xsl:when>
                                  <xsl:when test="$sayi =  3">Otuz </xsl:when>
                                  <xsl:when test="$sayi =  4">Kırk </xsl:when>
                                  <xsl:when test="$sayi =  5">Elli </xsl:when>
                                  <xsl:when test="$sayi =  6">Altmış </xsl:when>
                                  <xsl:when test="$sayi =  7">Yetmiş </xsl:when>
                                  <xsl:when test="$sayi =  8">Seksen </xsl:when>
                                  <xsl:when test="$sayi =  9">Doksan </xsl:when>
                                  <xsl:otherwise></xsl:otherwise>
                                </xsl:choose>
                              </xsl:template>
                              <xsl:template name="yuzler_oku">
                                <xsl:param name="sayi" />
                                <xsl:choose>
                                  <xsl:when test="$sayi =  1">Yüz </xsl:when>
                                  <xsl:when test="$sayi =  2">İki Yüz </xsl:when>
                                  <xsl:when test="$sayi =  3">Üç Yüz </xsl:when>
                                  <xsl:when test="$sayi =  4">Dört Yüz </xsl:when>
                                  <xsl:when test="$sayi =  5">Beş Yüz </xsl:when>
                                  <xsl:when test="$sayi =  6">Altı Yüz </xsl:when>
                                  <xsl:when test="$sayi =  7">Yedi Yüz </xsl:when>
                                  <xsl:when test="$sayi =  8">Sekiz Yüz </xsl:when>
                                  <xsl:when test="$sayi =  9">Dokuz Yüz </xsl:when>
                                  <xsl:otherwise></xsl:otherwise>
                                </xsl:choose>
                              </xsl:template>
                              <xsl:template name="binler_oku">
                                <xsl:param name="sayi" />
                                <xsl:choose>
                                  <xsl:when test="$sayi =  1">Bin </xsl:when>
                                  <xsl:when test="$sayi =  2">İki Bin </xsl:when>
                                  <xsl:when test="$sayi =  3">Üç Bin </xsl:when>
                                  <xsl:when test="$sayi =  4">Dört Bin </xsl:when>
                                  <xsl:when test="$sayi =  5">Beş Bin </xsl:when>
                                  <xsl:when test="$sayi =  6">Altı Bin </xsl:when>
                                  <xsl:when test="$sayi =  7">Yedi Bin </xsl:when>
                                  <xsl:when test="$sayi =  8">Sekiz Bin </xsl:when>
                                  <xsl:when test="$sayi =  9">Dokuz Bin </xsl:when>
                                  <xsl:otherwise></xsl:otherwise>
                                </xsl:choose>
                              </xsl:template>
                              <xsl:template name="onbinler_oku">
                                <xsl:param name="sayi" />
                                <xsl:if test="$sayi &gt; 0">
                                  <xsl:call-template name="onlar_oku" >
                                    <xsl:with-param name="sayi"  select="$sayi" />
                                  </xsl:call-template>Bin
                                </xsl:if>
                              </xsl:template>


                              <xsl:template name="Curr_Type">
                                <xsl:value-of select="format-number(., '###.##0,00', 'european')"/>
                                <xsl:if  test="@currencyID">
                                  <xsl:text> </xsl:text>
                                  <xsl:choose>
                                    <xsl:when test="@currencyID = 'TRL' or @currencyID = 'TRY'">
                                      <xsl:text>TL</xsl:text>
                                    </xsl:when>
                                    <xsl:otherwise>
                                      <xsl:value-of select="@currencyID"/>
                                    </xsl:otherwise>
                                  </xsl:choose>
                                </xsl:if>
                              </xsl:template>

                              <xsl:template name="TransportMode">
    <xsl:param name="TransportModeType" />
    <xsl:choose>
      <xsl:when test="$TransportModeType=1">Denizyolu</xsl:when>
      <xsl:when test="$TransportModeType=2">Demiryolu</xsl:when>
      <xsl:when test="$TransportModeType=3">Karayolu</xsl:when>
      <xsl:when test="$TransportModeType=4">Havayolu</xsl:when>
      <xsl:when test="$TransportModeType=5">Posta</xsl:when>
      <xsl:when test="$TransportModeType=6">Çok araçlı</xsl:when>
      <xsl:when test="$TransportModeType=7">Sabit taşıma tesisleri</xsl:when>
      <xsl:when test="$TransportModeType=8">İç su taşımacılığı</xsl:when>     
      <xsl:otherwise>
        <xsl:value-of select="$TransportModeType"/>
      </xsl:otherwise>
    </xsl:choose>   
  </xsl:template>

                            </xsl:stylesheet>

