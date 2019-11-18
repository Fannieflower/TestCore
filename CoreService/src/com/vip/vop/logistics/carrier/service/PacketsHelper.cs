using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class PacketsHelper : TBeanSerializer<Packets>
	{
		
		public static PacketsHelper OBJ = new PacketsHelper();
		
		public static PacketsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Packets structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("trade_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrade_id(value);
					}
					
					
					
					
					
					if ("packet_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.PacketResult> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.PacketResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.PacketResult elem0;
								
								elem0 = new com.vip.vop.logistics.carrier.service.PacketResult();
								com.vip.vop.logistics.carrier.service.PacketResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPacket_results(value);
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
		
		
		public void Write(Packets structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTrade_id() != null) {
				
				oprot.WriteFieldBegin("trade_id");
				oprot.WriteString(structs.GetTrade_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPacket_results() != null) {
				
				oprot.WriteFieldBegin("packet_results");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.PacketResult _item0 in structs.GetPacket_results()){
					
					
					com.vip.vop.logistics.carrier.service.PacketResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Packets bean){
			
			
		}
		
	}
	
}