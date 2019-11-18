using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringBatchCreateReqHelper : TBeanSerializer<TransferringBatchCreateReq>
	{
		
		public static TransferringBatchCreateReqHelper OBJ = new TransferringBatchCreateReqHelper();
		
		public static TransferringBatchCreateReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringBatchCreateReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetTransferring_type(value);
					}
					
					
					
					
					
					if ("ext_trans_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExt_trans_order_no(value);
					}
					
					
					
					
					
					if ("src_company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrc_company_code(value);
					}
					
					
					
					
					
					if ("src_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrc_warehouse_code(value);
					}
					
					
					
					
					
					if ("dest_company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDest_company_code(value);
					}
					
					
					
					
					
					if ("dest_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDest_warehouse_code(value);
					}
					
					
					
					
					
					if ("is_whale_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_whale_warehouse(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("estimated_arrival_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEstimated_arrival_time(value);
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
		
		
		public void Write(TransferringBatchCreateReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_type() != null) {
				
				oprot.WriteFieldBegin("transferring_type");
				oprot.WriteByte((byte)structs.GetTransferring_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transferring_type can not be null!");
			}
			
			
			if(structs.GetExt_trans_order_no() != null) {
				
				oprot.WriteFieldBegin("ext_trans_order_no");
				oprot.WriteString(structs.GetExt_trans_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ext_trans_order_no can not be null!");
			}
			
			
			if(structs.GetSrc_company_code() != null) {
				
				oprot.WriteFieldBegin("src_company_code");
				oprot.WriteString(structs.GetSrc_company_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("src_company_code can not be null!");
			}
			
			
			if(structs.GetSrc_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("src_warehouse_code");
				oprot.WriteString(structs.GetSrc_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("src_warehouse_code can not be null!");
			}
			
			
			if(structs.GetDest_company_code() != null) {
				
				oprot.WriteFieldBegin("dest_company_code");
				oprot.WriteString(structs.GetDest_company_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dest_company_code can not be null!");
			}
			
			
			if(structs.GetDest_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("dest_warehouse_code");
				oprot.WriteString(structs.GetDest_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dest_warehouse_code can not be null!");
			}
			
			
			if(structs.GetIs_whale_warehouse() != null) {
				
				oprot.WriteFieldBegin("is_whale_warehouse");
				oprot.WriteByte((byte)structs.GetIs_whale_warehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEstimated_arrival_time() != null) {
				
				oprot.WriteFieldBegin("estimated_arrival_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEstimated_arrival_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringBatchCreateReq bean){
			
			
		}
		
	}
	
}