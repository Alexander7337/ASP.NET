<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:template match="/*">
    <table>
      <tr>
        <th>Name</th>
        <th>Age</th>
        <th>Designation</th>
        <th>Town</th>
      </tr>
      <xsl:for-each select="Employee">
        <tr>
          <td>
            <xsl:value-of select="name"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="age"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="designation"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="town"/>
          </td>
        </tr>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>