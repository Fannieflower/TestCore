using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class CollectionPacketHelper : TBeanSerializer<CollectionPacket>
	{
		
		public static CollectionPacketHelper OBJ = new CollectionPacketHelper();
		
		public static CollectionPacketHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CollectionPacket structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.CollectionPacketItem> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.CollectionPacketItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.CollectionPacketItem elem0;
								
								elem0 = new com.vip.vop.logistics.carrier.service.CollectionPacketItem();
								com.vip.vop.logistics.carrier.service.CollectionPacketItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
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
		
		
		public void Write(CollectionPacket structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.CollectionPacketItem _item0 in structs.GetItems()){
					
					
					com.vip.vop.logistics.carrier.service.CollectionPacketItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CollectionPacket bean){
			
			
		}
		
	}
	
}