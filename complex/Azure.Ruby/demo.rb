$:.unshift( File.expand_path('../', __FILE__) )
require 'generated/azure_resources'

subscription_id = ENV['AZURE_SUBSCRIPTION_ID']
provider = MsRestAzure::ApplicationTokenProvider.new(
      ENV['AZURE_TENANT_ID'],
      ENV['AZURE_CLIENT_ID'],
      ENV['AZURE_CLIENT_SECRET'])
credentials = MsRest::TokenCredentials.new(provider)

client = Azure::ResourceManagementClient.new(credentials)
client.subscription_id = subscription_id

############################################
###
### Get the deserialized object (lazy paging)
###
############################################
client.resource_groups.list.each do |group|
    puts name: group.name, id: group.id
end

############################################
###
### Get all of you HTTP info
###
############################################
puts "\n" + JSON.dump(client.resource_groups.list_with_http_info)

############################################
###
### Who says Ruby can't do concurrency
###
############################################
promise = client.resource_groups.list_async

promise.then {|res|
    groups = res.body.value
    puts "\n #{groups.length.to_s}"
    groups
}.then {|groups|
    groups.each do |group|
        puts name: group.name, id: group.id
    end
}.value!
