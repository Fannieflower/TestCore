using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.cabinet{
	
	
	
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
					
					
					
					
					
					if ("express_cabinet_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpress_cabinet_code(value);
					}
					
					
					
					
					
					if ("express_cabinet_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpress_cabinet_name(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.Address value;
						
						value = new com.vip.vop.logistics.Address();
						com.vip.vop.logistics.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("longitude".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLongitude(value);
					}
					
					
					
					
					
					if ("latitude".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLatitude(value);
					}
					
					
					
					
					
					if ("linkman".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLinkman(value);
					}
					
					
					
					
					
					if ("linkman_tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLinkman_tel(value);
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
			
			
			if(structs.GetExpress_cabinet_code() != null) {
				
				oprot.WriteFieldBegin("express_cabinet_code");
				oprot.WriteString(structs.GetExpress_cabinet_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("express_cabinet_code can not be null!");
			}
			
			
			if(structs.GetExpress_cabinet_name() != null) {
				
				oprot.WriteFieldBegin("express_cabinet_name");
				oprot.WriteString(structs.GetExpress_cabinet_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				
				com.vip.vop.logistics.AddressHelper.getInstance().Write(structs.GetAddress(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("address can not be null!");
			}
			
			
			if(structs.GetLongitude() != null) {
				
				oprot.WriteFieldBegin("longitude");
				oprot.WriteString(structs.GetLongitude());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLatitude() != null) {
				
				oprot.WriteFieldBegin("latitude");
				oprot.WriteString(structs.GetLatitude());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLinkman() != null) {
				
				oprot.WriteFieldBegin("linkman");
				oprot.WriteString(structs.GetLinkman());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLinkman_tel() != null) {
				
				oprot.WriteFieldBegin("linkman_tel");
				oprot.WriteString(structs.GetLinkman_tel());
				
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