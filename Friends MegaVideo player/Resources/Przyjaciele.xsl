<?xml version="1.0" encoding="ISO-8859-1"?>
<!-- Edited by XMLSpy -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
  <h2>Lista odcinków serialu Friends (Przyjaciele)</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th>Sezon</th>
        <th>Nazwa Odcinka</th>
        <th>Nr w Sezonie</th>
        <th>Nr Ogólnie</th>
        <th>Link</th>   
      </tr>
      <xsl:for-each select="Spis/Odcinek">
      <tr>
        
		
		
		 <xsl:choose>		 
		 <xsl:when test="NazwaOdcinka = concat('Friends: The Stuff You', &quot;'&quot; ,'ve Never Seen')">
         <td bgcolor="Grey">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	    <xsl:when test="NazwaOdcinka = 'The One with All the Other Ones: Part 1'">
         <td bgcolor="Grey">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="NazwaOdcinka = 'The One with All the Other Ones: Part 2'">
         <td bgcolor="Grey">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Grey">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when> 
		 		 
		 		 
      <xsl:when test="Sezon = 1">
         <td bgcolor="Crimson" style="color:White">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Crimson" style="color:White">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Crimson" style="color:White">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Crimson" style="color:White">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Crimson" style="color:White">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 2">
         <td bgcolor="DarkOrange">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="DarkOrange">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="DarkOrange">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="DarkOrange">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="DarkOrange">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 3">
         <td bgcolor="Gold">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Gold">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Gold">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Gold">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Gold">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 4">
         <td bgcolor="LightGreen">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="LightGreen">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="LightGreen">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="LightGreen">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="LightGreen">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 5" >
         <td bgcolor="Blue" style="color:White">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Blue" style="color:White">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Blue" style="color:White">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Blue" style="color:White">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Blue" style="color:White">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 6">
         <td bgcolor="SteelBlue" style="color:White">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="SteelBlue" style="color:White">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="SteelBlue" style="color:White">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="SteelBlue" style="color:White">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="SteelBlue" style="color:White">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 7">
         <td bgcolor="SkyBlue">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="SkyBlue">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="SkyBlue">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="SkyBlue">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="SkyBlue">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 8">
         <td bgcolor="Tan">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Tan">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Tan">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Tan">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Tan">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 9">
         <td bgcolor="LightSeaGreen" style="color:White">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="LightSeaGreen" style="color:White">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="LightSeaGreen" style="color:White">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="LightSeaGreen" style="color:White">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="LightSeaGreen" style="color:White">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>
	  <xsl:when test="Sezon = 10">
         <td bgcolor="Pink">
         <xsl:value-of select="Sezon"/>
         </td>
		 <td bgcolor="Pink">
		 <xsl:value-of select="NazwaOdcinka" />
		 </td>
		 <td bgcolor="Pink">
		 <xsl:value-of select="NrWSezonie"/>
		 </td>
		 <td bgcolor="Pink">
		 <xsl:value-of select="NrOgolnie"/>
		 </td>
		 <td bgcolor="Pink">
		 <xsl:value-of select="Link"/>
		 </td>
      </xsl:when>   	    
      </xsl:choose>	   
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>
