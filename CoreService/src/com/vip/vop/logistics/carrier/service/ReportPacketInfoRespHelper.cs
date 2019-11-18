using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class ReportPacketInfoRespHelper : TBeanSerializer<ReportPacketInfoResp>
	{
		
		public static ReportPacketInfoRespHelper OBJ = new ReportPacketInfoRespHelper();
		
		public static ReportPacketInfoRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ReportPacketInfoResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("packetsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.Packets> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.Packets>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.Packets elem1;
								
								elem1 = new com.vip.vop.logistics.carrier.service.Packets();
								com.vip.vop.logistics.carrier.service.PacketsHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPacketsList(value);
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
		
		
		public void Write(ReportPacketInfoResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPacketsList() != null) {
				
				oprot.WriteFieldBegin("packetsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.Packets _item0 in structs.GetPacketsList()){
					
					
					com.vip.vop.logistics.carrier.service.PacketsHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ReportPacketInfoResp bean){
			
			
		}
		
	}
	
}