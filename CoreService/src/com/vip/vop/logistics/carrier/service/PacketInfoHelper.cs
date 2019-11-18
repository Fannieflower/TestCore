using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class PacketInfoHelper : TBeanSerializer<PacketInfo>
	{
		
		public static PacketInfoHelper OBJ = new PacketInfoHelper();
		
		public static PacketInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PacketInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("packets".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.Packet> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.Packet>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.Packet elem1;
								
								elem1 = new com.vip.vop.logistics.carrier.service.Packet();
								com.vip.vop.logistics.carrier.service.PacketHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPackets(value);
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
		
		
		public void Write(PacketInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTrade_id() != null) {
				
				oprot.WriteFieldBegin("trade_id");
				oprot.WriteString(structs.GetTrade_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trade_id can not be null!");
			}
			
			
			if(structs.GetPackets() != null) {
				
				oprot.WriteFieldBegin("packets");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.Packet _item0 in structs.GetPackets()){
					
					
					com.vip.vop.logistics.carrier.service.PacketHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packets can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PacketInfo bean){
			
			
		}
		
	}
	
}