using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics{
	
	
	
	public class ShipmentTraceHelper : TBeanSerializer<ShipmentTrace>
	{
		
		public static ShipmentTraceHelper OBJ = new ShipmentTraceHelper();
		
		public static ShipmentTraceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShipmentTrace structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("trace_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrace_code(value);
					}
					
					
					
					
					
					if ("action".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAction(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("op_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetOp_time(value);
					}
					
					
					
					
					
					if ("city_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity_name(value);
					}
					
					
					
					
					
					if ("site_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSite_code(value);
					}
					
					
					
					
					
					if ("site_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSite_name(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
					}
					
					
					
					
					
					if ("operator_tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator_tel(value);
					}
					
					
					
					
					
					if ("next_city_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNext_city_name(value);
					}
					
					
					
					
					
					if ("next_site_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNext_site_code(value);
					}
					
					
					
					
					
					if ("next_site_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNext_site_name(value);
					}
					
					
					
					
					
					if ("extend_fields".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.ExtendField> value;
						
						value = new List<com.vip.vop.logistics.ExtendField>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.ExtendField elem1;
								
								elem1 = new com.vip.vop.logistics.ExtendField();
								com.vip.vop.logistics.ExtendFieldHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetExtend_fields(value);
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
		
		
		public void Write(ShipmentTrace structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTrace_code() != null) {
				
				oprot.WriteFieldBegin("trace_code");
				oprot.WriteString(structs.GetTrace_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trace_code can not be null!");
			}
			
			
			if(structs.GetAction() != null) {
				
				oprot.WriteFieldBegin("action");
				oprot.WriteString(structs.GetAction());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("action can not be null!");
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("remark can not be null!");
			}
			
			
			if(structs.GetOp_time() != null) {
				
				oprot.WriteFieldBegin("op_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetOp_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("op_time can not be null!");
			}
			
			
			if(structs.GetCity_name() != null) {
				
				oprot.WriteFieldBegin("city_name");
				oprot.WriteString(structs.GetCity_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSite_code() != null) {
				
				oprot.WriteFieldBegin("site_code");
				oprot.WriteString(structs.GetSite_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSite_name() != null) {
				
				oprot.WriteFieldBegin("site_name");
				oprot.WriteString(structs.GetSite_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator_tel() != null) {
				
				oprot.WriteFieldBegin("operator_tel");
				oprot.WriteString(structs.GetOperator_tel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNext_city_name() != null) {
				
				oprot.WriteFieldBegin("next_city_name");
				oprot.WriteString(structs.GetNext_city_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNext_site_code() != null) {
				
				oprot.WriteFieldBegin("next_site_code");
				oprot.WriteString(structs.GetNext_site_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNext_site_name() != null) {
				
				oprot.WriteFieldBegin("next_site_name");
				oprot.WriteString(structs.GetNext_site_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtend_fields() != null) {
				
				oprot.WriteFieldBegin("extend_fields");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.ExtendField _item0 in structs.GetExtend_fields()){
					
					
					com.vip.vop.logistics.ExtendFieldHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShipmentTrace bean){
			
			
		}
		
	}
	
}