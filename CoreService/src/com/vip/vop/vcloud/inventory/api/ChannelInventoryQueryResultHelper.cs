using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	public class ChannelInventoryQueryResultHelper : TBeanSerializer<ChannelInventoryQueryResult>
	{
		
		public static ChannelInventoryQueryResultHelper OBJ = new ChannelInventoryQueryResultHelper();
		
		public static ChannelInventoryQueryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ChannelInventoryQueryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory> value;
						
						value = new List<com.vip.vop.vcloud.inventory.api.ChannelSkuInventory>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.inventory.api.ChannelSkuInventory elem0;
								
								elem0 = new com.vip.vop.vcloud.inventory.api.ChannelSkuInventory();
								com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetList(value);
					}
					
					
					
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.vcloud.common.api.Pagination value;
						
						value = new com.vip.vop.vcloud.common.api.Pagination();
						com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(ChannelInventoryQueryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetList() != null) {
				
				oprot.WriteFieldBegin("list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.inventory.api.ChannelSkuInventory _item0 in structs.GetList()){
					
					
					com.vip.vop.vcloud.inventory.api.ChannelSkuInventoryHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ChannelInventoryQueryResult bean){
			
			
		}
		
	}
	
}