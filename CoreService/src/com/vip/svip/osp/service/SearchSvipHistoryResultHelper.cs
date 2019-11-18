using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SearchSvipHistoryResultHelper : TBeanSerializer<SearchSvipHistoryResult>
	{
		
		public static SearchSvipHistoryResultHelper OBJ = new SearchSvipHistoryResultHelper();
		
		public static SearchSvipHistoryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SearchSvipHistoryResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("user_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUser_id(value);
					}
					
					
					
					
					
					if ("level".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLevel(value);
					}
					
					
					
					
					
					if ("exec_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetExec_type(value);
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
					
					
					
					
					
					if ("gift".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGift(value);
					}
					
					
					
					
					
					if ("start_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStart_time(value);
					}
					
					
					
					
					
					if ("end_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEnd_time(value);
					}
					
					
					
					
					
					if ("operate_user".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperate_user(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdate_time(value);
					}
					
					
					
					
					
					if ("open_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOpen_type(value);
					}
					
					
					
					
					
					if ("order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_no(value);
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
		
		
		public void Write(SearchSvipHistoryResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUser_id() != null) {
				
				oprot.WriteFieldBegin("user_id");
				oprot.WriteI64((long)structs.GetUser_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_id can not be null!");
			}
			
			
			if(structs.GetLevel() != null) {
				
				oprot.WriteFieldBegin("level");
				oprot.WriteString(structs.GetLevel());
				
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
			
			
			if(structs.GetGift() != null) {
				
				oprot.WriteFieldBegin("gift");
				oprot.WriteString(structs.GetGift());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStart_time() != null) {
				
				oprot.WriteFieldBegin("start_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStart_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnd_time() != null) {
				
				oprot.WriteFieldBegin("end_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEnd_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperate_user() != null) {
				
				oprot.WriteFieldBegin("operate_user");
				oprot.WriteString(structs.GetOperate_user());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteString(structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpen_type() != null) {
				
				oprot.WriteFieldBegin("open_type");
				oprot.WriteI32((int)structs.GetOpen_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("open_type can not be null!");
			}
			
			
			if(structs.GetOrder_no() != null) {
				
				oprot.WriteFieldBegin("order_no");
				oprot.WriteString(structs.GetOrder_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SearchSvipHistoryResult bean){
			
			
		}
		
	}
	
}