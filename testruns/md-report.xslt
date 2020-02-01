<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text"/>
  <xsl:template match="/">
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:variable name="newline">
    <xsl:text>&#xD;&#xA;</xsl:text>
  </xsl:variable>

  <xsl:variable name="break">
    <xsl:text>&#xD;&#xA;&#xD;&#xA;</xsl:text>
  </xsl:variable>

  <xsl:variable name="code">
    <xsl:text>&#xD;&#xA;    </xsl:text>
  </xsl:variable>

  <xsl:variable name="escaped-image">
    <xsl:text>    ![Board </xsl:text>
  </xsl:variable>

  <xsl:variable name="unescaped-image">
    <xsl:text>![Board </xsl:text>
  </xsl:variable>
  
  <xsl:template name="specflow">
    <xsl:param name="text" />
    <xsl:choose>
      <xsl:when test="$text = ''" >
        <!-- Prevent this routine from hanging -->
        <xsl:value-of select="$text" />
      </xsl:when>
	  <xsl:when test="(starts-with($text, 'Given ')) or (starts-with($text, 'When ')) or (starts-with($text, 'Then ')) or (starts-with($text, 'And '))">
	    <xsl:value-of select="'#### '" />
        <xsl:value-of select="substring-before($text,$newline)" />
        <xsl:value-of select="$newline" />
		<xsl:call-template name="specflow">
		  <xsl:with-param name="text" select="substring-after($text,$newline)" />
		</xsl:call-template>
	  </xsl:when>
	  <xsl:when test="starts-with($text, '-&gt; ')">
        <xsl:value-of select="$newline" />
	    <xsl:value-of select="' -&gt; '" />
        <xsl:value-of select="substring-before(substring($text, 4),$newline)" />
        <xsl:value-of select="$newline" />
		<xsl:call-template name="specflow">
		  <xsl:with-param name="text" select="substring-after($text,$newline)" />
		</xsl:call-template>
	  </xsl:when>
	  <xsl:when test="starts-with($text, '![')">
        <xsl:value-of select="substring-before($text,$newline)" />
        <xsl:value-of select="$newline" />
        <xsl:value-of select="$newline" />
		<xsl:call-template name="specflow">
		  <xsl:with-param name="text" select="substring-after($text,$newline)" />
		</xsl:call-template>
	  </xsl:when>
	  <xsl:when test="starts-with($text, '  --- table step argument ---')">
        <xsl:variable name="firstTableRow" select="substring-before(substring-after($text,$newline),$newline)" />
        <xsl:value-of select="$firstTableRow" />
        <xsl:value-of select="$newline" />
        <xsl:choose>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=2" >
		    <xsl:value-of select="'  | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=3" >
		    <xsl:value-of select="'  | - | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=4" >
		    <xsl:value-of select="'  | - | - | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=5" >
		    <xsl:value-of select="'  | - | - | - | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=6" >
		    <xsl:value-of select="'  | - | - | - | - | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=7" >
		    <xsl:value-of select="'  | - | - | - | - | - | - |'" />
		  </xsl:when>
		  <xsl:when test="(string-length($firstTableRow) - string-length(translate($firstTableRow, '|', '')))=8" >
		    <xsl:value-of select="'  | - | - | - | - | - | - | - |'" />
		  </xsl:when>
		  <xsl:otherwise>
		    <xsl:value-of select="'  | - | - | - | - | - | - | - | - |'" />
		  </xsl:otherwise>
        </xsl:choose>
        <xsl:value-of select="$newline" />
		<xsl:call-template name="specflow">
		  <xsl:with-param name="text" select="substring-after(substring-after($text,$newline),$newline)" />
		</xsl:call-template>
	  </xsl:when>
	  <xsl:when test="starts-with($text, '  | ')">
        <xsl:value-of select="substring-before($text,$newline)" />
        <xsl:value-of select="$newline" />
		<xsl:call-template name="specflow">
		  <xsl:with-param name="text" select="substring-after($text,$newline)" />
		</xsl:call-template>
	  </xsl:when>
      <xsl:when test="contains($text, $newline)">
        <xsl:value-of select="'    '" />
        <xsl:value-of select="substring-before($text,$newline)" />
        <xsl:value-of select="$newline" />
        <xsl:call-template name="specflow">
          <xsl:with-param name="text" select="substring-after($text,$newline)" />
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$text" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  
  <xsl:template name="string-replace-all">
    <xsl:param name="text" />
    <xsl:param name="replace" />
    <xsl:param name="by" />
    <xsl:choose>
      <xsl:when test="$text = '' or $replace = ''or not($replace)" >
        <!-- Prevent this routine from hanging -->
        <xsl:value-of select="$text" />
      </xsl:when>
      <xsl:when test="contains($text, $replace)">
        <xsl:value-of select="substring-before($text,$replace)" />
        <xsl:value-of select="$by" />
        <xsl:call-template name="string-replace-all">
          <xsl:with-param name="text" select="substring-after($text,$replace)" />
          <xsl:with-param name="replace" select="$replace" />
          <xsl:with-param name="by" select="$by" />
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$text" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  
  <xsl:template match="test-run">
    
    <!-- Runtime Environment -->
    <xsl:value-of select="concat('## Runtime Environment ', $break)"/>
    <xsl:value-of select="concat('   OS Version: ', test-suite/environment/@os-version[1], $break)"/>
    <xsl:value-of select="concat('  CLR Version: ', @clr-version, $break)"/>
    <xsl:value-of select="concat('NUnit Version: ', @engine-version, $break)"/>

    <!-- Test Files -->
    <xsl:value-of select="concat('## Test Files ', $break)"/>
    <xsl:for-each select="test-suite[@type='Assembly']">
      <xsl:value-of select="concat('    ', @fullname)"/>
      <xsl:if test="not(position() = last())">
        <xsl:value-of select="$break"/>
      </xsl:if>
    </xsl:for-each>

    <xsl:value-of select="$break"/>
    
    <!-- Tests Not Run -->
    <xsl:if test="//test-case[@result='Skipped']">
      <xsl:value-of select="concat('## Tests Not Run',$break)"/>
    </xsl:if>
    <xsl:apply-templates select="//test-case[@result='Skipped']"/>

    <!-- Errors and Failures -->
    <xsl:if test="//test-case[failure]">
      <xsl:value-of select="concat('## Errors and Failures',$break)"/>
    </xsl:if>
    <xsl:apply-templates select="//test-case[failure]"/>
    
    <!-- Tests Which Passed -->
    <xsl:if test="//test-case[@result='Passed']">
      <xsl:value-of select="concat('## Tests Which Passed',$break)"/>
    </xsl:if>
    <xsl:apply-templates select="//test-case[@result='Passed']"/>

    <!-- Run Settings (gets first one found) -->
    <xsl:variable name="settings" select ="//settings[1]" />
    <xsl:value-of select="concat('## Run Settings', $break)"/>
    <xsl:value-of select="concat('    ','DefaultTimeout: ', $settings/setting[@name='DefaultTimeout']/@value, $break)"/>
    <xsl:value-of select="concat('    ','WorkDirectory: ', $settings/setting[@name='WorkDirectory']/@value, $break)"/>
    <xsl:value-of select="concat('    ','ImageRuntimeVersion: ', $settings/setting[@name='ImageRuntimeVersion']/@value, $break)"/>
    <xsl:value-of select="concat('    ','ImageTargetFrameworkName: ', $settings/setting[@name='ImageTargetFrameworkName']/@value, $break)"/>
    <xsl:value-of select="concat('    ','ImageRequiresX86: ', $settings/setting[@name='ImageRequiresX86']/@value, $break)"/>
    <xsl:value-of select="concat('    ','ImageRequiresDefaultAppDomainAssemblyResolver: ', $settings/setting[@name='ImageRequiresDefaultAppDomainAssemblyResolver']/@value, $break)"/>
    <xsl:value-of select="concat('    ','NumberOfTestWorkers: ', $settings/setting[@name='NumberOfTestWorkers']/@value)"/>
    <xsl:value-of select="$break"/>

    <!-- Test Run Summary -->
    <xsl:value-of select="concat('## Test Run Summary ', $break)"/>
    <xsl:value-of select="concat(' Overall result: ', @result, $break)"/>
    <xsl:value-of select="concat(' Test Count: ', @total, ', Passed: ', @passed, ', Failed: ', @failed, ', Inconclusive: ', @inconclusive, ', Skipped: ', @skipped, $break)"/>

    <!-- [Optional] - Failed Test Summary -->
    <xsl:if test="@failed > 0">
      <xsl:variable name="failedTotal" select="count(//test-case[@result='Failed' and not(@label)])" />
      <xsl:variable name="errorsTotal" select="count(//test-case[@result='Failed' and @label='Error'])" />
      <xsl:variable name="invalidTotal" select="count(//test-case[@result='Failed' and @label='Invalid'])" />
      <xsl:value-of select="concat('   Failed Tests - Failures: ', $failedTotal, ', Errors: ', $errorsTotal, ', Invalid: ', $invalidTotal, $break)"/>
    </xsl:if>

    <!-- [Optional] - Skipped Test Summary -->
    <xsl:if test="@skipped > 0">
      <xsl:variable name="ignoredTotal" select="count(//test-case[@result='Skipped' and @label='Ignored'])" />
      <xsl:variable name="explicitTotal" select="count(//test-case[@result='Skipped' and @label='Explicit'])" />
      <xsl:variable name="otherTotal" select="count(//test-case[@result='Skipped' and not(@label='Explicit' or @label='Ignored')])" />
      <xsl:value-of select="concat('   Skipped Tests - Ignored: ', $ignoredTotal, ', Explicit: ', $explicitTotal, ', Other: ', $otherTotal, $break)"/>
    </xsl:if>

    <!-- Times -->
    <xsl:value-of select="concat(' Start time: ', @start-time, $break)"/>
    <xsl:value-of select="concat('   End time: ', @end-time, $break)"/>
    <xsl:value-of select="concat('   Duration: ', format-number(@duration,'0.000'), ' seconds', $break)"/>

  </xsl:template>

  <xsl:template match="test-case">
    <!-- Determine type of test-case for formatting -->
    <xsl:variable name="type">
      <xsl:choose>
        <xsl:when test="@result='Skipped'">
          <xsl:choose>
            <xsl:when test="@label='Ignored' or @label='Explicit'">
              <xsl:value-of select="@label"/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select="'Other'"/>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:when>
        <xsl:when test="@result='Failed'">
          <xsl:choose>
            <xsl:when test="@label='Error' or @label='Invalid'">
              <xsl:value-of select="@label"/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select="'Failed'"/>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:when>
        <xsl:when test="@result='Passed'">
          <xsl:choose>
            <xsl:when test="@label='Error' or @label='Invalid'">
              <xsl:value-of select="@label"/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select="'Passed'"/>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select="'Unknown'"/>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:variable>
    
    <!-- Show details of test-cases either skipped or errored -->
    <xsl:value-of select="concat('### ', position(), ') ', $type,' : ', @fullname, $break, child::node()/message)"/>
    <xsl:value-of select="$break"/>

    <!-- Stack trace for failures -->
    <xsl:if test="failure">
      <xsl:choose>
        <xsl:when test="$type='Failed'">
          <xsl:call-template name="string-replace-all">
            <xsl:with-param name="text" select="failure/stack-trace" />
            <xsl:with-param name="replace" select="$newline" />
            <xsl:with-param name="by" select="$code" />
          </xsl:call-template>
          <xsl:value-of select="$break"/>
           <xsl:call-template name="specflow">
            <xsl:with-param name="text" select="output" />
          </xsl:call-template>
          <xsl:value-of select="$break"/>
       </xsl:when>
        <xsl:when test="$type='Error'">
          <xsl:call-template name="string-replace-all">
            <xsl:with-param name="text" select="failure/stack-trace" />
            <xsl:with-param name="replace" select="$newline" />
            <xsl:with-param name="by" select="$code" />
          </xsl:call-template>
          <xsl:value-of select="$break"/>
          <xsl:call-template name="specflow">
            <xsl:with-param name="text" select="output" />
          </xsl:call-template>
          <xsl:value-of select="$break"/>
        </xsl:when>
      </xsl:choose>
    </xsl:if>

    <!-- Output for successes -->
    <xsl:if test="not(failure)">
      <xsl:choose>
        <xsl:when test="$type='Passed'">
          <xsl:call-template name="specflow">
            <xsl:with-param name="text" select="output" />
          </xsl:call-template>
          <xsl:value-of select="$break"/>
        </xsl:when>
      </xsl:choose>
    </xsl:if>

  </xsl:template>

</xsl:stylesheet>
