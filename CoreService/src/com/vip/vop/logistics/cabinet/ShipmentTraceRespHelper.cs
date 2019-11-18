using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class ShipmentTraceRespHelper : TBeanSerializer<ShipmentTraceResp>
	{
		
		public static ShipmentTraceRespHelper OBJ = new ShipmentTraceRespHelper();
		
		public static ShipmentTraceRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShipmentTraceResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("shipment_trace_result".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.cabinet.ShipmentTraceResult> value;
						
						value = new List<com.vip.vop.logistics.cabinet.ShipmentTraceResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.cabinet.ShipmentTraceResult elem1;
								
								elem1 = new com.vip.vop.logistics.cabinet.ShipmentTraceResult();
								com.vip.vop.logistics.cabinet.ShipmentTraceResultHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShipment_trace_result(value);
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
		
		
		public void Write(ShipmentTraceResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetShipment_trace_result() != null) {
				
				oprot.WriteFieldBegin("shipment_trace_result");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.cabinet.ShipmentTraceResult _item0 in structs.GetShipment_trace_result()){
					
					
					com.vip.vop.logistics.cabinet.ShipmentTraceResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShipmentTraceResp bean){
			
			
		}
		
	}
	
}