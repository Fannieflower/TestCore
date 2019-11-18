using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class StatPoCommonStructHelper : TBeanSerializer<StatPoCommonStruct>
	{
		
		public static StatPoCommonStructHelper OBJ = new StatPoCommonStructHelper();
		
		public static StatPoCommonStructHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StatPoCommonStruct structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchaseQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchaseQuantity(value);
					}
					
					
					
					
					
					if ("avgAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetAvgAmount(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmount(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetDiscount(value);
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
		
		
		public void Write(StatPoCommonStruct structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchaseQuantity() != null) {
				
				oprot.WriteFieldBegin("purchaseQuantity");
				oprot.WriteI32((int)structs.GetPurchaseQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseQuantity can not be null!");
			}
			
			
			if(structs.GetAvgAmount() != null) {
				
				oprot.WriteFieldBegin("avgAmount");
				oprot.WriteDouble((double)structs.GetAvgAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("avgAmount can not be null!");
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteDouble((double)structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalAmount can not be null!");
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteDouble((double)structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("discount can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StatPoCommonStruct bean){
			
			
		}
		
	}
	
}