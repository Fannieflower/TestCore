using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics{
	
	
	
	public class ShipmentTraceListHelper : TBeanSerializer<ShipmentTraceList>
	{
		
		public static ShipmentTraceListHelper OBJ = new ShipmentTraceListHelper();
		
		public static ShipmentTraceListHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShipmentTraceList structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logistics_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogistics_no(value);
					}
					
					
					
					
					
					if ("traces".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.ShipmentTrace> value;
						
						value = new List<com.vip.vop.logistics.ShipmentTrace>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.ShipmentTrace elem0;
								
								elem0 = new com.vip.vop.logistics.ShipmentTrace();
								com.vip.vop.logistics.ShipmentTraceHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTraces(value);
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
		
		
		public void Write(ShipmentTraceList structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogistics_no() != null) {
				
				oprot.WriteFieldBegin("logistics_no");
				oprot.WriteString(structs.GetLogistics_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logistics_no can not be null!");
			}
			
			
			if(structs.GetTraces() != null) {
				
				oprot.WriteFieldBegin("traces");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.ShipmentTrace _item0 in structs.GetTraces()){
					
					
					com.vip.vop.logistics.ShipmentTraceHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("traces can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShipmentTraceList bean){
			
			
		}
		
	}
	
}