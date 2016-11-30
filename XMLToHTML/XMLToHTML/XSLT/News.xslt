<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:template match="/*">
    <table>
      <tr>
        <th>Title</th>
        <th>Description</th>
        <th>Link</th>
        <th>Date Published</th>
      </tr>
      <xsl:for-each select="channel">
      <xsl:for-each select="item">
        <tr>
          <td>
            <xsl:value-of select="title"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="description"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="link"></xsl:value-of>
          </td>
          <td>
            <xsl:value-of select="pubDate"/>
          </td>
        </tr>
      </xsl:for-each>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>
