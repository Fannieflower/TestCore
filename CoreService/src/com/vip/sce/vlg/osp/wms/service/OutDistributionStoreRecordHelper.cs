using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	public class OutDistributionStoreRecordHelper : TBeanSerializer<OutDistributionStoreRecord>
	{
		
		public static OutDistributionStoreRecordHelper OBJ = new OutDistributionStoreRecordHelper();
		
		public static OutDistributionStoreRecordHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OutDistributionStoreRecord structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transactionId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("billtype".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBilltype(value);
					}
					
					
					
					
					
					if ("transportMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportMode(value);
					}
					
					
					
					
					
					if ("transportTool".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportTool(value);
					}
					
					
					
					
					
					if ("carrierUnit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierUnit(value);
					}
					
					
					
					
					
					if ("carrierMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierMode(value);
					}
					
					
					
					
					
					if ("logisticsNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogisticsNo(value);
					}
					
					
					
					
					
					if ("plateNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlateNumber(value);
					}
					
					
					
					
					
					if ("transporter".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransporter(value);
					}
					
					
					
					
					
					if ("departureTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDepartureTime(value);
					}
					
					
					
					
					
					if ("temperature".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTemperature(value);
					}
					
					
					
					
					
					if ("humidity".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetHumidity(value);
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
		
		
		public void Write(OutDistributionStoreRecord structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransactionId() != null) {
				
				oprot.WriteFieldBegin("transactionId");
				oprot.WriteString(structs.GetTransactionId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transactionId can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetBilltype() != null) {
				
				oprot.WriteFieldBegin("billtype");
				oprot.WriteString(structs.GetBilltype());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("billtype can not be null!");
			}
			
			
			if(structs.GetTransportMode() != null) {
				
				oprot.WriteFieldBegin("transportMode");
				oprot.WriteString(structs.GetTransportMode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transportMode can not be null!");
			}
			
			
			if(structs.GetTransportTool() != null) {
				
				oprot.WriteFieldBegin("transportTool");
				oprot.WriteString(structs.GetTransportTool());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transportTool can not be null!");
			}
			
			
			if(structs.GetCarrierUnit() != null) {
				
				oprot.WriteFieldBegin("carrierUnit");
				oprot.WriteString(structs.GetCarrierUnit());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrierUnit can not be null!");
			}
			
			
			if(structs.GetCarrierMode() != null) {
				
				oprot.WriteFieldBegin("carrierMode");
				oprot.WriteString(structs.GetCarrierMode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrierMode can not be null!");
			}
			
			
			if(structs.GetLogisticsNo() != null) {
				
				oprot.WriteFieldBegin("logisticsNo");
				oprot.WriteString(structs.GetLogisticsNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logisticsNo can not be null!");
			}
			
			
			if(structs.GetPlateNumber() != null) {
				
				oprot.WriteFieldBegin("plateNumber");
				oprot.WriteString(structs.GetPlateNumber());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("plateNumber can not be null!");
			}
			
			
			if(structs.GetTransporter() != null) {
				
				oprot.WriteFieldBegin("transporter");
				oprot.WriteString(structs.GetTransporter());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transporter can not be null!");
			}
			
			
			if(structs.GetDepartureTime() != null) {
				
				oprot.WriteFieldBegin("departureTime");
				oprot.WriteString(structs.GetDepartureTime());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("departureTime can not be null!");
			}
			
			
			if(structs.GetTemperature() != null) {
				
				oprot.WriteFieldBegin("temperature");
				oprot.WriteDouble((double)structs.GetTemperature());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("temperature can not be null!");
			}
			
			
			if(structs.GetHumidity() != null) {
				
				oprot.WriteFieldBegin("humidity");
				oprot.WriteDouble((double)structs.GetHumidity());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("humidity can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OutDistributionStoreRecord bean){
			
			
		}
		
	}
	
}