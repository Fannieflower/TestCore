using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.sims.erp{
	
	
	
	public class InventoryAdjustReqHelper : TBeanSerializer<InventoryAdjustReq>
	{
		
		public static InventoryAdjustReqHelper OBJ = new InventoryAdjustReqHelper();
		
		public static InventoryAdjustReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InventoryAdjustReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("xlsBarcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetXlsBarcode(value);
					}
					
					
					
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("bizReceiptType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBizReceiptType(value);
					}
					
					
					
					
					
					if ("bizReceiptCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizReceiptCode(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("bizTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBizTime(value);
					}
					
					
					
					
					
					if ("optUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOptUser(value);
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
		
		
		public void Write(InventoryAdjustReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seqNo can not be null!");
			}
			
			
			if(structs.GetXlsBarcode() != null) {
				
				oprot.WriteFieldBegin("xlsBarcode");
				oprot.WriteString(structs.GetXlsBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("xlsBarcode can not be null!");
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeCode can not be null!");
			}
			
			
			if(structs.GetBizReceiptType() != null) {
				
				oprot.WriteFieldBegin("bizReceiptType");
				oprot.WriteI32((int)structs.GetBizReceiptType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizReceiptType can not be null!");
			}
			
			
			if(structs.GetBizReceiptCode() != null) {
				
				oprot.WriteFieldBegin("bizReceiptCode");
				oprot.WriteString(structs.GetBizReceiptCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizReceiptCode can not be null!");
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteI32((int)structs.GetQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("quantity can not be null!");
			}
			
			
			if(structs.GetBizTime() != null) {
				
				oprot.WriteFieldBegin("bizTime");
				oprot.WriteI64((long)structs.GetBizTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizTime can not be null!");
			}
			
			
			if(structs.GetOptUser() != null) {
				
				oprot.WriteFieldBegin("optUser");
				oprot.WriteString(structs.GetOptUser());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("optUser can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InventoryAdjustReq bean){
			
			
		}
		
	}
	
}