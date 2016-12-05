$:.unshift( File.expand_path('../', __FILE__) )

require 'generated/helloworld'

client = HelloWorld::HelloWorld.new(MsRest::ServiceClientCredentials.new)
puts client.greeting.get