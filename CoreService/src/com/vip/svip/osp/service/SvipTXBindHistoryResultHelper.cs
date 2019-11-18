using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipTXBindHistoryResultHelper : TBeanSerializer<SvipTXBindHistoryResult>
	{
		
		public static SvipTXBindHistoryResultHelper OBJ = new SvipTXBindHistoryResultHelper();
		
		public static SvipTXBindHistoryResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipTXBindHistoryResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_no(value);
					}
					
					
					
					
					
					if ("tencent_acct_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTencent_acct_type(value);
					}
					
					
					
					
					
					if ("tencent_member_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTencent_member_type(value);
					}
					
					
					
					
					
					if ("tencent_acct".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTencent_acct(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("tx_nick_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTx_nick_name(value);
					}
					
					
					
					
					
					if ("tx_figure_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTx_figure_url(value);
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
		
		
		public void Write(SvipTXBindHistoryResult structs, Protocol oprot){
			
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
			
			
			if(structs.GetOrder_no() != null) {
				
				oprot.WriteFieldBegin("order_no");
				oprot.WriteString(structs.GetOrder_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTencent_acct_type() != null) {
				
				oprot.WriteFieldBegin("tencent_acct_type");
				oprot.WriteI32((int)structs.GetTencent_acct_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("tencent_acct_type can not be null!");
			}
			
			
			if(structs.GetTencent_member_type() != null) {
				
				oprot.WriteFieldBegin("tencent_member_type");
				oprot.WriteI32((int)structs.GetTencent_member_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("tencent_member_type can not be null!");
			}
			
			
			if(structs.GetTencent_acct() != null) {
				
				oprot.WriteFieldBegin("tencent_acct");
				oprot.WriteString(structs.GetTencent_acct());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTx_nick_name() != null) {
				
				oprot.WriteFieldBegin("tx_nick_name");
				oprot.WriteString(structs.GetTx_nick_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTx_figure_url() != null) {
				
				oprot.WriteFieldBegin("tx_figure_url");
				oprot.WriteString(structs.GetTx_figure_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipTXBindHistoryResult bean){
			
			
		}
		
	}
	
}