using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderApiModelHelper : TBeanSerializer<TransferringOrderApiModel>
	{
		
		public static TransferringOrderApiModelHelper OBJ = new TransferringOrderApiModelHelper();
		
		public static TransferringOrderApiModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderApiModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("transferring_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_order_no(value);
					}
					
					
					
					
					
					if ("transferring_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTransferring_type(value);
					}
					
					
					
					
					
					if ("src_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrc_warehouse_code(value);
					}
					
					
					
					
					
					if ("dest_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDest_warehouse_code(value);
					}
					
					
					
					
					
					if ("created_by_user_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreated_by_user_id(value);
					}
					
					
					
					
					
					if ("is_whale_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_whale_warehouse(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("estimated_arrival_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEstimated_arrival_time(value);
					}
					
					
					
					
					
					if ("pre_created".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPre_created(value);
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
		
		
		public void Write(TransferringOrderApiModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransferring_order_no() != null) {
				
				oprot.WriteFieldBegin("transferring_order_no");
				oprot.WriteString(structs.GetTransferring_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransferring_type() != null) {
				
				oprot.WriteFieldBegin("transferring_type");
				oprot.WriteByte((byte)structs.GetTransferring_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrc_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("src_warehouse_code");
				oprot.WriteString(structs.GetSrc_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("src_warehouse_code can not be null!");
			}
			
			
			if(structs.GetDest_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("dest_warehouse_code");
				oprot.WriteString(structs.GetDest_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dest_warehouse_code can not be null!");
			}
			
			
			if(structs.GetCreated_by_user_id() != null) {
				
				oprot.WriteFieldBegin("created_by_user_id");
				oprot.WriteString(structs.GetCreated_by_user_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_whale_warehouse() != null) {
				
				oprot.WriteFieldBegin("is_whale_warehouse");
				oprot.WriteByte((byte)structs.GetIs_whale_warehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEstimated_arrival_time() != null) {
				
				oprot.WriteFieldBegin("estimated_arrival_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEstimated_arrival_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPre_created() != null) {
				
				oprot.WriteFieldBegin("pre_created");
				oprot.WriteByte((byte)structs.GetPre_created()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringOrderApiModel bean){
			
			
		}
		
	}
	
}