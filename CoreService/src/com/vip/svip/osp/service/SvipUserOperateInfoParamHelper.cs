using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipUserOperateInfoParamHelper : TBeanSerializer<SvipUserOperateInfoParam>
	{
		
		public static SvipUserOperateInfoParamHelper OBJ = new SvipUserOperateInfoParamHelper();
		
		public static SvipUserOperateInfoParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipUserOperateInfoParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("user_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUser_id(value);
					}
					
					
					
					
					
					if ("order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_no(value);
					}
					
					
					
					
					
					if ("product_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetProduct_id(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("exec_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetExec_type(value);
					}
					
					
					
					
					
					if ("open_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOpen_type(value);
					}
					
					
					
					
					
					if ("days".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDays(value);
					}
					
					
					
					
					
					if ("exec_source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExec_source(value);
					}
					
					
					
					
					
					if ("exec_content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExec_content(value);
					}
					
					
					
					
					
					if ("operate_user".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperate_user(value);
					}
					
					
					
					
					
					if ("unique_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUnique_code(value);
					}
					
					
					
					
					
					if ("extension".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtension(value);
					}
					
					
					
					
					
					if ("ip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIp(value);
					}
					
					
					
					
					
					if ("platform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlatform(value);
					}
					
					
					
					
					
					if ("dateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDateTime(value);
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
		
		
		public void Write(SvipUserOperateInfoParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUser_id() != null) {
				
				oprot.WriteFieldBegin("user_id");
				oprot.WriteI64((long)structs.GetUser_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_no() != null) {
				
				oprot.WriteFieldBegin("order_no");
				oprot.WriteString(structs.GetOrder_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProduct_id() != null) {
				
				oprot.WriteFieldBegin("product_id");
				oprot.WriteI64((long)structs.GetProduct_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteString(structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExec_type() != null) {
				
				oprot.WriteFieldBegin("exec_type");
				oprot.WriteI32((int)structs.GetExec_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("exec_type can not be null!");
			}
			
			
			if(structs.GetOpen_type() != null) {
				
				oprot.WriteFieldBegin("open_type");
				oprot.WriteI32((int)structs.GetOpen_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("open_type can not be null!");
			}
			
			
			if(structs.GetDays() != null) {
				
				oprot.WriteFieldBegin("days");
				oprot.WriteI32((int)structs.GetDays()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("days can not be null!");
			}
			
			
			if(structs.GetExec_source() != null) {
				
				oprot.WriteFieldBegin("exec_source");
				oprot.WriteString(structs.GetExec_source());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExec_content() != null) {
				
				oprot.WriteFieldBegin("exec_content");
				oprot.WriteString(structs.GetExec_content());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperate_user() != null) {
				
				oprot.WriteFieldBegin("operate_user");
				oprot.WriteString(structs.GetOperate_user());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUnique_code() != null) {
				
				oprot.WriteFieldBegin("unique_code");
				oprot.WriteString(structs.GetUnique_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtension() != null) {
				
				oprot.WriteFieldBegin("extension");
				oprot.WriteString(structs.GetExtension());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIp() != null) {
				
				oprot.WriteFieldBegin("ip");
				oprot.WriteString(structs.GetIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlatform() != null) {
				
				oprot.WriteFieldBegin("platform");
				oprot.WriteString(structs.GetPlatform());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDateTime() != null) {
				
				oprot.WriteFieldBegin("dateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipUserOperateInfoParam bean){
			
			
		}
		
	}
	
}