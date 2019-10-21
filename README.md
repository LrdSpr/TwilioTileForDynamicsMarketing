# Twilio Tile For Dynamics Marketing

The repository contains an example of custom tile for the Dynamics Marketing customer journey. This example includes the following components:

1. Configuration files for Customer Journey: CJTwilioTile.Assets\Config\TwilioSMSCustomerJourneyDesignerTileConfig.css and CJTwilioTile.Assets\Config\TwilioSMSCustomerJourneyDesignerTileConfig.xml

2. Solution file which contains compiled a version of the plugin and required entities: CJTwilioTile.Assets\Solutions\CustomerJourney_1_0_0_0.zip

3. Plugin project "CJTwilioTile.Plugins" which is executing the procedure. The plugin should be configured. ContentSettings constant should be updated according to your Dynamics Marketing. 

Integration with Twilio implemented using Microsoft Flow. You should create Microsoft Flow to send SMS, which should be executed for entity pk_twiliosmstemplate.
