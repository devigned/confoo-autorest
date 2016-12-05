$:.unshift( File.expand_path('../', __FILE__) )
require 'generated/helloworld'

#######################################################
###
### Super simple get request based on helloworld.json
###
#######################################################
client = HelloWorld::HelloWorld.new(MsRest::ServiceClientCredentials.new)
puts client.greeting.get