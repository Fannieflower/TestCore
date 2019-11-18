using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
	public class ExpressCabinetTraceReqHelper : TBeanSerializer<ExpressCabinetTraceReq>
	{
		
		public static ExpressCabinetTraceReqHelper OBJ = new ExpressCabinetTraceReqHelper();
		
		public static ExpressCabinetTraceReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExpressCabinetTraceReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("shipment_traces".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.cabinet.ShipmentTraceList> value;
						
						value = new List<com.vip.vop.logistics.cabinet.ShipmentTraceList>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.cabinet.ShipmentTraceList elem1;
								
								elem1 = new com.vip.vop.logistics.cabinet.ShipmentTraceList();
								com.vip.vop.logistics.cabinet.ShipmentTraceListHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShipment_traces(value);
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
		
		
		public void Write(ExpressCabinetTraceReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetShipment_traces() != null) {
				
				oprot.WriteFieldBegin("shipment_traces");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.cabinet.ShipmentTraceList _item0 in structs.GetShipment_traces()){
					
					
					com.vip.vop.logistics.cabinet.ShipmentTraceListHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("shipment_traces can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExpressCabinetTraceReq bean){
			
			
		}
		
	}
	
}